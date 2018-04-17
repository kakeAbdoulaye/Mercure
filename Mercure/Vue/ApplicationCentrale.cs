using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercure.InterfaceBaseDonnee;
using Mercure.Models;
using System.Xml;
using System.Collections;

namespace Mercure.Vue
{
    /// <summary>
    ///  Cette classe represente l'application Centrale du projet , elle permet la gestion des articles 
    ///  , des menus pour: 
    ///  - L'intégration du fichier XML dans la base de données 
    ///  - L'affichage : 
    ///     - Des marques
    ///     - Des sous familles
    ///     - Des familles
    ///  - L'Ajout :
    ///     - Article
    ///     - Marque
    ///     - Sous Famille
    ///     - Famille
    ///  - Quitter l'application
    ///  - Un status pour afficher la dernière action 
    /// </summary>
    public partial class ApplicatioCentrale : Form
    {
        /// <summary>
        ///  Attribut permettant le tri sur une colonne 
        /// </summary>
        private ListViewColumnTri ColumnTri;

        /// <summary>
        /// Attribut des gestions des groupes sur les colonnes 
        /// </summary>
        private GestionGroupTri GroupTri;

        /// <summary>
        /// Constructeur d'un objet de type ApplicatioCentrale
        /// </summary>
        public ApplicatioCentrale()
        {
            InitializeComponent();
            RemplirListeArticle();
            ColumnTri = new ListViewColumnTri();
            ListView_Articles.ListViewItemSorter = ColumnTri;
            GroupTri = new GestionGroupTri(ListView_Articles);
            
        }

        /// <summary>
        /// Cette methode permet de mettre à jour la liste view contenant les articles  
        /// </summary>
        /// <remarks>
        ///  On libère la liste view puis la remplie avec des nouveaux articles 
        /// </remarks>
        private void MettreJourArticles()
        {
            ListView_Articles.Groups.Clear();
            ListView_Articles.Clear();
            RemplirListeArticle();
        }

        /// <summary>
        ///  Cette methode permet d'aller chercher dans la base de données Tous les articles et remplir la liste View de ces articles
        ///  , en indiquant les noms de colonne 
        /// </summary>
        private void RemplirListeArticle()
        {
            InterfaceDB_Articles interArticle = new InterfaceDB_Articles();
            int indice = 0;

            ColumnHeader Crefarcticle = new ColumnHeader();
            Crefarcticle.Text = "RefArticle";
            Crefarcticle.Width = 80;

            ColumnHeader Cdescription = new ColumnHeader();
            Cdescription.Text = "Description";
            Cdescription.Width = 300;

            ColumnHeader Cfamille = new ColumnHeader();
            Cfamille.Text = "Famille";
            Cfamille.Width = 120;

            ColumnHeader Csousfamille = new ColumnHeader();
            Csousfamille.Text = "Sous Famille";
            Csousfamille.Width = 120;

            ColumnHeader Cmarque = new ColumnHeader();
            Cmarque.Text = "Marque";
            Cmarque.Width = 100;

            ColumnHeader Cprix = new ColumnHeader();
            Cprix.Text = "Prix HT";
            Cprix.Width = 60;

            ColumnHeader Cquantite = new ColumnHeader();
            Cquantite.Text = "Quantite";
            Cquantite.Width = 60;

            ListView_Articles.Columns.AddRange(new ColumnHeader[] { Crefarcticle, Cdescription, Cfamille, Csousfamille, Cmarque, Cprix, Cquantite });

            List<Article> listeArticle = interArticle.GetToutesArticle();

            ListViewItem[] listeItemArticle = new ListViewItem[listeArticle.Count];

            if(listeArticle != null)
            {
                foreach (Article article in listeArticle)
                {
                    string[] chaineArticle = new string[] { article.RefArticle, article.Description, article.SousFamille.MaFamille.NomFamille, article.SousFamille.NomSousFamille, article.Marque.NomMarque, article.PrixHT.ToString(), article.Quantite.ToString() };

                    ListViewItem itemArticle = new ListViewItem(chaineArticle);
                    listeItemArticle[indice] = itemArticle;
                    indice++;
                }
            }
           

            this.ListView_Articles.Items.AddRange(listeItemArticle);
        }

        /// <summary>
        ///  Cette methode de se déconnecter à la base de données lors de la fermeture de l'application 
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ApplicatioCentrale_FormClosing(object sender, FormClosingEventArgs e)
        {
            InterfaceDB.Deconnection();
        }

        /// <summary>
        ///  Cette methode permet de changer le label status de l'application lors d'une opération
        /// </summary>
        /// <param name="chaine"> l'action faite sur l'application </param>
        private void ChangementStatus(string chaine)
        {
            this.Statuslabel_Operation.Text = chaine;
        }

        /// <summary>
        ///  Cette méthode permet d'ouvir une fenetre modale d'ajout d'un article <see cref="Ajouter_Modifier_Article"/>
        /// </summary>
        /// <remarks>
        ///     Après la fermeture de cette fenetre modale , on met à jour la liste view des articles <see cref="ListView_Articles"/>  et 
        ///     on change  le status de l'application si l'ajout à reussi 
        /// </remarks>
        private void AjouterArticle()
        {
            Ajouter_Modifier_Article ajout = new Ajouter_Modifier_Article("Ajouter Article");
            ajout.ShowDialog(this);
            MettreJourArticles();
            if (ajout.Reussi == true)
            {
                ChangementStatus("Un nouvel article ajouté ");
            }
        }

        /// <summary>
        /// Cette méthode permet l'ouverture d'une fenetre modale permettant la modification d'un article <see cref="Ajouter_Modifier_Article"/>
        /// </summary>
        /// <remarks>
        ///     la fenetre modale ne s'ouvre que si une ligne est sélectionnée , et la modification se base sur la colonne contenant la reférence de l'article
        ///     on met à jour la liste view des articles <see cref="ListView_Articles"/> , on change  le status de l'application si la modification à reussi 
        /// </remarks>
        private void ModifierArticle()
        {
            if (ListView_Articles.SelectedItems.Count > 0)
            {
                ListViewItem item = ListView_Articles.SelectedItems[0];
                string refarticle = item.SubItems[0].Text;
                Ajouter_Modifier_Article fenetremodifArticle = new Ajouter_Modifier_Article("Modification Article ", refarticle);
                fenetremodifArticle.ShowDialog(this);
                if(fenetremodifArticle.Reussi == true)
                {
                    ChangementStatus("Un article a été modifié");
                }
                MettreJourArticles();
            }
        }

        /// <summary>
        ///     Cette méthode permet de supprimer un article dans la base de données 
        /// </summary>
        /// <remarks>
        ///     la suppression est faite que si une ligne est sélectionnée , et un message box est affiché pour demander à l'utilisateur de confirmer la suppression
        ///     on met à jour la liste view des articles <see cref="ListView_Articles"/> , on change  le status de l'application si la suppression à reussi 
        /// </remarks>
        private void SupprimerArticle()
        {
            int count = ListView_Articles.Items.Count;
            if (ListView_Articles.SelectedItems.Count > 0)
            {
                DialogResult reponse = MessageBox.Show("Voulez-vous supprimer cet article ? ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (reponse == DialogResult.OK)
                {
                    ListViewItem item = ListView_Articles.SelectedItems[0];
                    string refarticle = item.SubItems[0].Text;
                    InterfaceDB_Articles inter = new InterfaceDB_Articles();
                    inter.SupprimerArticle(refarticle);
                    MettreJourArticles();
                    if (count > ListView_Articles.Items.Count)
                    {
                        ChangementStatus("Un  article a été supprimé ");
                    }
                }

            }
        }

        /// <summary>
        ///  Cette methode permet de gerer l'évènement d'un clic droit en ouvrant un menu  <see cref="ContextMenu_OptionClicDroit"/> contenant des options d'ajout , suppression et de modification d'un article
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ListView_Articles_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.ContextMenu_OptionClicDroit.Show(Cursor.Position);
            }
        }

        /// <summary>
        ///  Cette methode permet de gerer l'evènement double clic qui permet la modification d'un article <see cref="ModifierArticle"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ListView_Articles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifierArticle();
        }

        /// <summary>
        ///  Cette methode permet de gérer les évènements claviers
        /// -  F5 : pour mettre à jour la liste view <see cref="MettreJourArticles"/>
        /// - Supp : pour supprimer un article <see cref="SupprimerArticle"/>
        /// - Entrer : pour modifier un article <see cref="ModifierArticle"/>
        ///  
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ListView_Articles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                MettreJourArticles();

            }
            else if (e.KeyCode == Keys.Delete)
            {
                SupprimerArticle();
                
            }
            else if (e.KeyCode == Keys.Enter)
            {
                ModifierArticle();
            }
        }

        /// <summary>
        ///  Cette methode permet d'ouvrir une fenetre modale <see cref="ApplicationFamille"/> pour l'affichage des familles 
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void AfficherFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationFamille appli = new ApplicationFamille();
            appli.ShowDialog(this);
            MettreJourArticles();
        }

        /// <summary>
        ///  Cette methode permet d'ouvrir une fenetre modale <see cref="Ajouter_Modifier_Famille"/> pour l'ajout d'une famille 
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void AjouterFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Modifier_Famille appli = new Ajouter_Modifier_Famille("Ajouter Famille");
            appli.ShowDialog(this);
            MettreJourArticles();
        }

        /// <summary>
        ///  Cette methode permet d'ouvrir une fenetre modale <see cref="ApplicationSousFamille"/> pour l'affichage des sous familles 
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void AfficherSousFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationSousFamille appli = new ApplicationSousFamille();
            appli.ShowDialog(this);
            MettreJourArticles();
        }

        /// <summary>
        ///  Cette methode permet d'ouvrir une fenetre modale <see cref="Ajouter_Modifier_SousFamille"/> pour l'ajout d'une sous famille 
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void AjouterSousFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Modifier_SousFamille appli = new Ajouter_Modifier_SousFamille("Ajouter Sous Famille");
            appli.ShowDialog(this);
            MettreJourArticles();
        }

        /// <summary>
        ///  Cette methode permet d'ouvrir une fenetre modale <see cref="ApplicationMarque"/> pour l'affichage des marques 
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void AfficherMarqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationMarque appli = new ApplicationMarque();
            appli.ShowDialog(this);
            MettreJourArticles();
        }

        /// <summary>
        ///  Cette methode permet d'ouvrir une fenetre modale <see cref="Ajouter_Modifier_Marque"/> pour l'ajout d'une marque
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void AjouterMarqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Modifier_Marque appli = new Ajouter_Modifier_Marque("Ajouter Marque");
            appli.ShowDialog(this);
            MettreJourArticles();
        }

        /// <summary>
        ///  Cette methode permet d'ouvrir une fenetre modale <see cref="Fenetre_Integration"/> pour l'intégration ou mise jour des données de la base de données à travers le fichier XML
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void OuvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fenetre_Integration integration = new Fenetre_Integration();
            integration.ShowDialog(this);
            MettreJourArticles();
            if(integration.Reussi == 1)
            {
                ChangementStatus("La nouvelle intégration des données a réussi");
            }
            else if(integration.Reussi == 2)
            {
                ChangementStatus("La nouvelle mise à jour des données a réussi");
            }
        }

        /// <summary>
        ///  Cette methode gere l'évènement de clic sur l'option ajout du <see cref="ContextMenu_OptionClicDroit"/> pour ajouter un article 
        ///  gràce la fonction <see cref="AjouterArticle"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void AjouterToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AjouterArticle();
            MettreJourArticles();
        }

        /// <summary>
        ///  Cette methode gere l'évènement de clic sur l'option modifier du <see cref="ContextMenu_OptionClicDroit"/> pour modifier un article 
        ///  gràce la fonction <see cref="ModifierArticle"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierArticle();
            MettreJourArticles();
        }

        /// <summary>
        ///  Cette methode gere l'évènement de clic sur l'option supprimer du <see cref="ContextMenu_OptionClicDroit"/> pour supprimer un article 
        ///  gràce la fonction <see cref="SupprimerArticle"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void SupprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerArticle();
            MettreJourArticles();
        }

        /// <summary>
        /// Cette methode gere l'évènement de clic sur le bouton ajout de la barre d'outil pour ajouter un article voir <see cref="AjouterArticle"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ToolStripButton_AjoutArticle_Click(object sender, EventArgs e)
        {
            AjouterArticle();
            MettreJourArticles();
        }

        /// <summary>
        ///  Cette methode permet de fermer l'application et de se deconnecter de la base de données 
        /// </summary>
        private void QuitterApplication()
        {
            DialogResult reponse = MessageBox.Show("Voulez-vous vraiment quitté ? ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (reponse == DialogResult.OK)
            {
                InterfaceDB.Deconnection();
                this.Close();
            }
               
        }

        /// <summary>
        /// Cette methode gere l'évènement de clic sur le menu quitter ,  pour quitter l'application  voir <see cref="QuitterApplication"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuitterApplication();
        }

        /// <summary>
        /// Cette methode gere l'évènement de clic sur le bouton quitter de la barre d'outil pour quitter l'application  voir <see cref="QuitterApplication"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ToolStripButton_QuitterApplication_Click(object sender, EventArgs e)
        {
            QuitterApplication();
        }
    }
}

