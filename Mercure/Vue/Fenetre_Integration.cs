using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Mercure.InterfaceBaseDonnee;
using Mercure.Models;

namespace Mercure.Vue
{
    public partial class Fenetre_Integration : Form
    {
        /// <summary>
        /// Prendre le text contenu dans  text pour la lecture 
        /// tant que le champ du fichier est vide le groupbox integration sera inactif aussi
        /// quand on appuie sur un bouton (integration totale / update) l'autre est désactivé jusqu'à la fin de l'integration
        /// verifier que le fichier choisie est correcte sinon faite une erreur (fait)
        /// </summary>
        ///  si une marque est référencié on ne peut pas le supprimer , mettre à jour si existe sinon le cree (fait) , en levé la saisie des reférences dans marque , sous famill , famille (fait)
        private string nomFicherXML = "";
        private int count;
        private string resultatErreur;

        delegate void AjouterFinLigneResultatErreurs(string text);

        public Fenetre_Integration()
        {
            InitializeComponent();

        }

        private void button_choix_fichier_Click(object sender, EventArgs e)
        {
            DialogResult dialogueResultXML = this.Ouvrir_XML_Fichier.ShowDialog();
            if (dialogueResultXML == DialogResult.OK)
            {
                this.nomFicherXML = this.Ouvrir_XML_Fichier.FileName;
                XmlDocument documentXml = new XmlDocument();
                documentXml.Load(this.nomFicherXML);
                count = Int32.Parse(documentXml.CreateNavigator().Evaluate("count(//article)").ToString());
                text_chemin_fichier_choisi.Text = nomFicherXML;
            }
        }

        private void text_chemin_fichier_choisi_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(text_chemin_fichier_choisi.Text))
            {
               
                button_integration.Enabled = false;
            }
            else
            {
                if (radioButton_mise_jour.Checked == true || radioButton_nouvelle_Integration.Checked == true)
                {
                    button_integration.Enabled = true;
                }
                   
            }
        }

        private void text_chemin_fichier_choisi_VisibleChanged(object sender, EventArgs e)
        {
            text_chemin_fichier_choisi_TextChanged(sender, e);
        }

        private void Travail_En_Arriere_Plan_DoWork(object sender, DoWorkEventArgs e)
        {
            if (radioButton_mise_jour.Checked == true)
            {
                FileMisejour();
            }
             else if (radioButton_nouvelle_Integration.Checked == true)
            {
                FileIntegration();
            } 
               
        }

        private void Travail_En_Arriere_Plan_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Bar_Progression_Integration_fichier_XML.Value = e.ProgressPercentage;
   
        }

        private void Travail_En_Arriere_Plan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Chargement et insertion des éléments du fichier XML dans la base de Données", "Information de Chargement ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Bar_Progression_Integration_fichier_XML.Value = 0;
            text_chemin_fichier_choisi.Text = "";
        }
       
        private void ChangerResultat(String text)
        {
            textBox_affichage_resultateterreurs.Text += text + Environment.NewLine;
        }
        private void FileIntegration()
        {
            int increment = 0;
            XmlDocument documentXml = new XmlDocument();

            /**
             * Suppression des tables de la base de données 
             * */
            resultatErreur = InterfaceDB.supprimerToutTable("Articles");
            textBox_affichage_resultateterreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), resultatErreur);
            resultatErreur = InterfaceDB.supprimerToutTable("Familles");
            textBox_affichage_resultateterreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), resultatErreur);
            resultatErreur = InterfaceDB.supprimerToutTable("SousFamilles");
            textBox_affichage_resultateterreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), resultatErreur);
            resultatErreur = InterfaceDB.supprimerToutTable("Marques");
            textBox_affichage_resultateterreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), resultatErreur);
            

            /**
             * Lecture des Elements dans le fichier xml choisie 
             * */
            this.nomFicherXML = this.Ouvrir_XML_Fichier.FileName;
            documentXml.Load(this.nomFicherXML);

            foreach (XmlNode enregistrement in documentXml.DocumentElement)
            {
                /**
                 * Pour chaque noeud je recupère les élements d'un article 
                 * En creer la marque , la famille , la sous famille puis l'article 
                 */

                string descriptionActicle = enregistrement.SelectSingleNode("description").InnerText;
                string refArticle = enregistrement.SelectSingleNode("refArticle").InnerText;
                double prixArticle = Double.Parse(enregistrement.SelectSingleNode("prixHT").InnerText);
                int quantiteArticle = 1;

                string nomSousfamille = enregistrement.SelectSingleNode("sousFamille").InnerText;
                string nomfamille = enregistrement.SelectSingleNode("famille").InnerText;
                string nomMarque = enregistrement.SelectSingleNode("marque").InnerText;

                /**
                 * L'ordre  d'insertion est importante  
                 */

                InterfaceDB_Marque marque = new InterfaceDB_Marque();
                resultatErreur = marque.insererMarque(nomMarque);
                textBox_affichage_resultateterreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), resultatErreur);
    

                InterfaceDB_Famille famille = new InterfaceDB_Famille();
                resultatErreur = famille.insererFamille(nomfamille);
                textBox_affichage_resultateterreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), resultatErreur);

                InterfaceDB_Sous_Famille sousfamille = new InterfaceDB_Sous_Famille();               
                resultatErreur = sousfamille.insererSousFamille(nomfamille, nomSousfamille);
                textBox_affichage_resultateterreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), resultatErreur);

                Marque marqueArticle = marque.getMarque(nomMarque);
                SousFamille sousFamilleArticle = sousfamille.getSousFamille(nomSousfamille);

               

                if (marqueArticle != null && sousFamilleArticle != null)
                {
                    InterfaceDB_Articles article = new InterfaceDB_Articles();  
                    resultatErreur = article.insererArticle(refArticle, descriptionActicle, sousFamilleArticle.RefSousFamille, marqueArticle.RefMarque, prixArticle, quantiteArticle);
                    textBox_affichage_resultateterreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), resultatErreur);
                }
               
                increment++;
                Travail_En_Arriere_Plan.ReportProgress(increment);


            }
        }
        private void FileMisejour()
        {
            Article articleMisejour;
            Marque marqueMisejour;
            Famille familleMisejour;
            SousFamille sousfamilleMisejour;
            InterfaceDB_Articles interArticle = new InterfaceDB_Articles();
            InterfaceDB_Marque interMarque = new InterfaceDB_Marque();
            InterfaceDB_Famille interfamille = new InterfaceDB_Famille();
            InterfaceDB_Sous_Famille interSousfamille = new InterfaceDB_Sous_Famille();

            int increment = 0;
            XmlDocument documentXml = new XmlDocument();
            this.nomFicherXML = this.Ouvrir_XML_Fichier.FileName;
            documentXml.Load(this.nomFicherXML);

            foreach (XmlNode enregistrement in documentXml.DocumentElement)
            {
                string descriptionActicle = enregistrement.SelectSingleNode("description").InnerText;
                string refArticle = enregistrement.SelectSingleNode("refArticle").InnerText;
                double prixArticle = Double.Parse(enregistrement.SelectSingleNode("prixHT").InnerText);
                int quantiteArticle = 1;

                string nomSousfamille = enregistrement.SelectSingleNode("sousFamille").InnerText;
                string nomfamille = enregistrement.SelectSingleNode("famille").InnerText;
                string nomMarque = enregistrement.SelectSingleNode("marque").InnerText;

                /**
                 * La marque 
                 * */
                marqueMisejour = interMarque.getMarque(nomMarque);
                if(marqueMisejour == null)
                {
                    resultatErreur = interMarque.insererMarque(nomMarque);
                    textBox_affichage_resultateterreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), resultatErreur);
                    marqueMisejour = interMarque.getMarque(nomMarque);
                }
                /**
                 * La famille 
                 */
                familleMisejour = interfamille.getFamille(nomfamille);
                if(familleMisejour == null)
                {
                    resultatErreur = interfamille.insererFamille(nomfamille);
                    textBox_affichage_resultateterreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), resultatErreur);
                    familleMisejour = interfamille.getFamille(nomfamille);
                }

                /**
                 * La sous famille 
                 * */
                sousfamilleMisejour = interSousfamille.getSousFamille(nomSousfamille);
                if(sousfamilleMisejour == null)
                {
                    resultatErreur = interSousfamille.insererSousFamille(nomfamille, nomSousfamille);
                    textBox_affichage_resultateterreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), resultatErreur);
                    sousfamilleMisejour = interSousfamille.getSousFamille(nomSousfamille);
                }
                else
                {
                    if(sousfamilleMisejour.MaFamille.RefFamille != familleMisejour.RefFamille)
                    {
                        resultatErreur = interSousfamille.modifierSousFamille(sousfamilleMisejour.RefSousFamille, familleMisejour.RefFamille, sousfamilleMisejour.NomSousFamille);
                        textBox_affichage_resultateterreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), resultatErreur);
                    }
                }

                /**
                 * L'article 
                 * */

                articleMisejour =  interArticle.getArticle(refArticle);
                if(articleMisejour == null)
                {
                    resultatErreur = interArticle.insererArticle(refArticle, descriptionActicle, sousfamilleMisejour.RefSousFamille, marqueMisejour.RefMarque, prixArticle, quantiteArticle);
                    textBox_affichage_resultateterreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), resultatErreur);
                }
                else
                {
                   resultatErreur = interArticle.modifierArticle(refArticle, descriptionActicle, sousfamilleMisejour.RefSousFamille, marqueMisejour.RefMarque, prixArticle, quantiteArticle);
                    textBox_affichage_resultateterreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), resultatErreur);
                }
                increment++;
                Travail_En_Arriere_Plan.ReportProgress(increment);


            }
        }

        private void button_integration_Click(object sender, EventArgs e)
        {
            Bar_Progression_Integration_fichier_XML.Maximum = count;
            button_integration.Enabled = false;
            Travail_En_Arriere_Plan.RunWorkerAsync();

        }

     
        private void radioButton_nouvelle_Integration_CheckedChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(text_chemin_fichier_choisi.Text))
            {
                this.button_integration.Enabled = true;
            }
          
        }

        private void radioButton_mise_jour_CheckedChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(text_chemin_fichier_choisi.Text))
            {
                this.button_integration.Enabled = true;
            }
        }
    }
}
