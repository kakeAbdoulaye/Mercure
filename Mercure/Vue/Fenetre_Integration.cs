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
    /// <summary>
    ///  Cette classe représente la fenetre d'intégration d'un fichier xml avec un mode d'intégration dans la base de données
    /// </summary>
    /// <remarks>
    ///     Cette fenetre permet de : 
    ///         - choisir un fichier de type xml
    ///         - Choisir un mode d'intégration : intégration ou mise à jour 
    ///         - Afficher la barre de progression  lors de l'intégration / mise à jour 
    ///         - Les actions faites sur la base de données lors de l'intégration / mise à jour 
    /// </remarks>
    public partial class Fenetre_Integration : Form
    {

        /// <summary>
        ///  Attribut indiquant le chemin du fichier xml  choisie 
        /// </summary>
        private string NomFicherXML= "";

        /// <summary>
        ///  Attribut indiquant le nombre de noeud article dans le fichier xml 
        /// </summary>
        private int Count;

        /// <summary>
        /// Attribut contenant le resultat de chaque opération 
        /// </summary>
        private string ResultatErreur;

        /// <summary>
        ///  Cette methode de type delegate permettant de signaler l'ajout en fin de ligne d'un resulat
        /// </summary>
        /// <param name="text">le resultat d'une opération </param>
        delegate void AjouterFinLigneResultatErreurs(string text);

        /// <summary>
        ///  Constructeur par defaut 
        /// </summary>
        public Fenetre_Integration()
        {
            InitializeComponent();

        }

        /// <summary>
        ///  Cette methode permet de choisir un fichier après un click  sur le bouton de choix de fichier 
        ///
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        /// <remarks>
        ///     Le choix de fichier est fait avec un <see cref="OpenFileDialog"/>
        /// </remarks>
        private void Button_Choix_Fichier_Click(object sender, EventArgs e)
        {
            DialogResult dialogueResultXML = this.Ouvrir_XML_Fichier.ShowDialog();

            if (dialogueResultXML == DialogResult.OK)
            {
                this.NomFicherXML = this.Ouvrir_XML_Fichier.FileName;
                XmlDocument documentXml = new XmlDocument();
                documentXml.Load(this.NomFicherXML);
                Count = Int32.Parse(documentXml.CreateNavigator().Evaluate("count(//article)").ToString());
                Text_Chemin_Fichier_Choisi.Text = NomFicherXML;
            }
        }

        /// <summary>
        ///  Cette permet de gerer l'évenement : quand le contenu du text Box indiquant le chemin du fichier choisi change ,
        ///  elle sert réellement à activer ou désactiviser le bouton d'intégration / mise à jour si un fichier n'est pas choisie 
        ///  donc si le text box est vide ou null 
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void Text_Chemin_Fichier_Choisi_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Text_Chemin_Fichier_Choisi.Text))
            {

                Button_Integration.Enabled = false;
            }
            else
            {
                if (RadioButton_Mise_Jour.Checked == true || RadioButton_Nouvelle_Integration.Checked == true)
                {
                    Button_Integration.Enabled = true;
                }

            }
        }

        /// <summary>
        ///  Cette methode permet de faire le travail du <see cref="BackgroundWorker"/> , elle est directement déclenché au moment 
        ///  où notre back Worker veut lancer un boulot .
        ///  Elle lance soit l'intégration ou la mise à jour en fontion du bouton radio choisie 
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void Travail_En_Arriere_Plan_DoWork(object sender, DoWorkEventArgs e)
        {
            if (RadioButton_Mise_Jour.Checked == true)
            {
                FileMisejour();
            }
             else if (RadioButton_Nouvelle_Integration.Checked == true)
            {
                FileIntegration();
            } 
               
        }

        /// <summary>
        ///  Cette methode permet d'incrémenter la bar de progression 
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void Travail_En_Arriere_Plan_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Bar_Progression_Integration_Fichier_XML.Value = e.ProgressPercentage;
   
        }

        private void Travail_En_Arriere_Plan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("le Chargement et l'insertion des éléments du fichier XML dans la base de Données sont finis", "Information de Chargement ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Bar_Progression_Integration_Fichier_XML.Value = 0;
            Text_Chemin_Fichier_Choisi.Text = "";
        }
       
        /// <summary>
        ///  Cette methode permet d'ajouter en fin de ligne dans la Text Box d'affichage le resultat d'une opération sur la base de données
        /// </summary>
        /// <param name="text"> resultat d'une opération </param>
        private void ChangerResultat(String text)
        {
            TextBox_Affichage_ResultatEtErreurs.Text += text + Environment.NewLine;
        }

        /// <summary>
        /// Cette methode permet de lire le contenu du fichier xml et inserer dans la base de données 
        /// </summary>
        /// <remarks>
        ///    -  Elle supprime en premier lieu , toutes les tuples qui se trouvent dans les différents tables de la base de données 
        ///    -  Puis ouvre et lit  le fichier XML avec <see cref="XmlDocument"/>
        ///    -  Pour chaque noeud lu , elle cree une marque , une famille , une sous famille puis un article si ils existent pas déjà
        /// </remarks>
        private void FileIntegration()
        {
            int increment = 0;
            XmlDocument documentXml = new XmlDocument();

            /**
             * Suppression des tables de la base de données 
             * */
            ResultatErreur = InterfaceDB.SupprimerToutTable("Articles");
            TextBox_Affichage_ResultatEtErreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), ResultatErreur);
            ResultatErreur = InterfaceDB.SupprimerToutTable("Familles");
            TextBox_Affichage_ResultatEtErreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), ResultatErreur);
            ResultatErreur = InterfaceDB.SupprimerToutTable("SousFamilles");
            TextBox_Affichage_ResultatEtErreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), ResultatErreur);
            ResultatErreur = InterfaceDB.SupprimerToutTable("Marques");
            TextBox_Affichage_ResultatEtErreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), ResultatErreur);
            

            /**
             * Lecture des Elements dans le fichier xml choisie 
             * */
            this.NomFicherXML = this.Ouvrir_XML_Fichier.FileName;
            documentXml.Load(this.NomFicherXML);

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
                ResultatErreur = marque.InsererMarque(nomMarque);
                TextBox_Affichage_ResultatEtErreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), ResultatErreur);
    

                InterfaceDB_Famille famille = new InterfaceDB_Famille();
                ResultatErreur = famille.InsererFamille(nomfamille);
                TextBox_Affichage_ResultatEtErreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), ResultatErreur);

                InterfaceDB_Sous_Famille sousfamille = new InterfaceDB_Sous_Famille();               
                ResultatErreur = sousfamille.InsererSousFamille(nomfamille, nomSousfamille);
                TextBox_Affichage_ResultatEtErreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), ResultatErreur);

                Marque marqueArticle = marque.GetMarque(nomMarque);
                SousFamille sousFamilleArticle = sousfamille.GetSousFamille(nomSousfamille);

               

                if (marqueArticle != null && sousFamilleArticle != null)
                {
                    InterfaceDB_Articles article = new InterfaceDB_Articles();  
                    ResultatErreur = article.InsererArticle(refArticle, descriptionActicle, sousFamilleArticle.RefSousFamille, marqueArticle.RefMarque, prixArticle, quantiteArticle);
                    TextBox_Affichage_ResultatEtErreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), ResultatErreur);
                }
               
                increment++;
                Travail_En_Arriere_Plan.ReportProgress(increment);


            }
        }


        /// <summary>
        /// Cette methode permet de lire le contenu du fichier xml et mettre à jour les informations des articles dans la base de données 
        /// </summary>
        /// <remarks>
        ///       Elle permet de : 
        ///    -  Ouvre et lit  le fichier XML avec <see cref="XmlDocument"/>
        ///    -  Pour chaque noeud lu , elle met à jour un article avec les nouveaux éléments d'un fichier 
        ///      - si la marque , la  famille et la sous famille existent alors l'action est faite directement
        ///      - sinon on cree l'objet puis on met à jour l'article 
        ///    - Si l'article n'existe pas avant dans la base de données alors il est crée
        /// </remarks>
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
            this.NomFicherXML = this.Ouvrir_XML_Fichier.FileName;
            documentXml.Load(this.NomFicherXML);

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
                marqueMisejour = interMarque.GetMarque(nomMarque);
                if(marqueMisejour == null)
                {
                    ResultatErreur = interMarque.InsererMarque(nomMarque);
                    TextBox_Affichage_ResultatEtErreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), ResultatErreur);
                    marqueMisejour = interMarque.GetMarque(nomMarque);
                }
                /**
                 * La famille 
                 */
                familleMisejour = interfamille.GetFamille(nomfamille);
                if(familleMisejour == null)
                {
                    ResultatErreur = interfamille.InsererFamille(nomfamille);
                    TextBox_Affichage_ResultatEtErreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), ResultatErreur);
                    familleMisejour = interfamille.GetFamille(nomfamille);
                }

                /**
                 * La sous famille 
                 * */
                sousfamilleMisejour = interSousfamille.GetSousFamille(nomSousfamille);
                if(sousfamilleMisejour == null)
                {
                    ResultatErreur = interSousfamille.InsererSousFamille(nomfamille, nomSousfamille);
                    TextBox_Affichage_ResultatEtErreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), ResultatErreur);
                    sousfamilleMisejour = interSousfamille.GetSousFamille(nomSousfamille);
                }
                else
                {
                    if(sousfamilleMisejour.MaFamille.RefFamille != familleMisejour.RefFamille)
                    {
                        ResultatErreur = interSousfamille.ModifierSousFamille(sousfamilleMisejour.RefSousFamille, familleMisejour.RefFamille, sousfamilleMisejour.NomSousFamille);
                        TextBox_Affichage_ResultatEtErreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), ResultatErreur);
                    }
                }

                /**
                 * L'article 
                 * */

                articleMisejour =  interArticle.GetArticle(refArticle);
                if(articleMisejour == null)
                {
                    ResultatErreur = interArticle.InsererArticle(refArticle, descriptionActicle, sousfamilleMisejour.RefSousFamille, marqueMisejour.RefMarque, prixArticle, quantiteArticle);
                    TextBox_Affichage_ResultatEtErreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), ResultatErreur);
                }
                else
                {
                   ResultatErreur = interArticle.ModifierArticle(refArticle, descriptionActicle, sousfamilleMisejour.RefSousFamille, marqueMisejour.RefMarque, prixArticle, quantiteArticle);
                    TextBox_Affichage_ResultatEtErreurs.Invoke(new AjouterFinLigneResultatErreurs(ChangerResultat), ResultatErreur);
                }
                increment++;
                Travail_En_Arriere_Plan.ReportProgress(increment);


            }
        }
        /// <summary>
        ///  Cette permet de d'activier ou désactivier le bouton d'intégration quand on check le bouton radio NOuvelle intégration 
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void RadioButton_Nouvelle_Integration_CheckedChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Text_Chemin_Fichier_Choisi.Text))
            {
                this.Button_Integration.Enabled = true;
            }
        }

        /// <summary>
        ///  Cette permet de d'activier ou désactivier le bouton d'intégration quand on check le bouton radio Mise à jour
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void RadioButton_Mise_Jour_CheckedChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Text_Chemin_Fichier_Choisi.Text))
            {
                this.Button_Integration.Enabled = true;
            }
        }

        /// <summary>
        ///  Cette methode permet de lancer notre <see cref="BackgroundWorker"/> après avoir cliqué sur le bouton Intégration 
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        /// <remarks> 
        ///     Elle désactive le bouton d'intégration pour empêcher l'utiliser de lancer un notre travail alors que le 1 er n'est pas fini
        /// </remarks>
        private void Button_Integration_Click(object sender, EventArgs e)
        {
            Bar_Progression_Integration_Fichier_XML.Maximum = Count;
            Button_Integration.Enabled = false;
            Travail_En_Arriere_Plan.RunWorkerAsync();
        }



    }
}
