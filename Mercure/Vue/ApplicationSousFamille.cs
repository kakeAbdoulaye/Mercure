using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercure.InterfaceBaseDonnee;
using Mercure.Models;
using System.Windows.Forms;
using System.Collections;

namespace Mercure.Vue
{
    /// <summary>
    ///  Cette classe represente l'application de la sous famille, elle permet la gestion des sous familles 
    ///  , comme : 
    ///  
    ///  - L'affichage : 
    ///     - Des sous  familles
    ///  - L'Ajout d'une sous Famille
    ///  - La modification d'une sous famille 
    ///  - la suppresion d'une sous famille 
    ///  - Quitter l'application
    ///  - Un status pour afficher la dernière action 
    /// </summary>
    public partial class ApplicationSousFamille : Form
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
        /// Constructeur d'un objet de type ApplicationSousFamille
        /// </summary>
        public ApplicationSousFamille()
        {
            InitializeComponent();
            RemplirListeSousFamille();
            ColumnTri = new ListViewColumnTri();
            this.ListView_SousFamille.ListViewItemSorter = ColumnTri;
            GroupTri = new GestionGroupTri(ListView_SousFamille);
        }

        /// <summary>
        /// Cette methode permet de mettre à jour la liste view contenant les sous familles  
        /// </summary>
        /// <remarks>
        ///  On libère la liste view puis la remplie avec des nouvelles sous familles 
        /// </remarks>
        public void MettreJourSousFamilles()
        {
            ListView_SousFamille.Clear();
            RemplirListeSousFamille();
        }

        /// <summary>
        ///  Cette methode permet d'aller chercher dans la base de données Toutes les sous familles et remplir la liste View de ces sous familles
        ///  , en indiquant les noms de colonne 
        /// </summary>
        public void RemplirListeSousFamille()
        {
            InterfaceDB_Sous_Famille interSousfamille = new InterfaceDB_Sous_Famille();
            int indice = 0;

            ColumnHeader Crefsousfamille = new ColumnHeader();
            Crefsousfamille.Text = "Ref Sous Famille";
            Crefsousfamille.Width = 100;

            ColumnHeader CrefFamille = new ColumnHeader();
            CrefFamille.Text = "Famille ";
            CrefFamille.Width = 150;

            ColumnHeader Cnomsousfamille = new ColumnHeader();
            Cnomsousfamille.Text = "Nom ";
            Cnomsousfamille.Width = -2;


            this.ListView_SousFamille.Columns.AddRange(new ColumnHeader[] { Crefsousfamille, CrefFamille, Cnomsousfamille });

            List<SousFamille> listeSousfamille = interSousfamille.getToutesSousFamille();

            ListViewItem[] listeItem = new ListViewItem[listeSousfamille.Count];

            foreach (SousFamille sousfamille in listeSousfamille)
            {
                string[] chaine = new string[] { sousfamille.RefSousFamille.ToString(), sousfamille.MaFamille.NomFamille, sousfamille.NomSousFamille };

                ListViewItem item = new ListViewItem(chaine);
                listeItem[indice] = item;
                indice++;
            }

            this.ListView_SousFamille.Items.AddRange(listeItem);

        }

        /// <summary>
        ///  Cette methode permet de changer le label status de l'application lors d'une opération
        /// </summary>
        /// <param name="chaine"> l'action faite sur l'application </param>
        private void ChangementStatus(string chaine)
        {
            this.StatusLabel_Operation.Text = chaine;
        }

        /// <summary>
        ///  Cette méthode permet d'ouvir une fenetre modale d'ajout d'une sous famille <see cref="Ajouter_Modifier_SousFamille"/>
        /// </summary>
        /// <remarks>
        ///     Après la fermeture de cette fenetre modale , on met à jour la liste view des sous familles <see cref="ListView_SousFamille"/>  et 
        ///     on change  le status de l'application si l'ajout à reussi 
        /// </remarks>
        private void AjouterSousFamille()
        {
            Ajouter_Modifier_SousFamille ajout = new Ajouter_Modifier_SousFamille("Ajout Sous Famille");
            ajout.ShowDialog(this);
            MettreJourSousFamilles();
            if(ajout.Reussi)
            {
                ChangementStatus("Une nouvelle sous famille ajoutée");
            }

        }

        /// <summary>
        /// Cette méthode permet l'ouverture d'une fenetre modale permettant la modification d'une sous famille <see cref="Ajouter_Modifier_SousFamille"/>
        /// </summary>
        /// <remarks>
        ///     la fenetre modale ne s'ouvre que si une ligne est sélectionnée , et la modification se base sur la colonne contenant la reférence de la sous famille
        ///     on met à jour la liste view des sous  familles <see cref="ListView_SousFamille"/> , on change  le status de l'application si la modification à reussi 
        /// </remarks>
        private void ModifierSousFamille()
        {
            if (ListView_SousFamille.SelectedItems.Count > 0)
            {
                ListViewItem item = ListView_SousFamille.SelectedItems[0];
                int refsousfamille = Int32.Parse(item.SubItems[0].Text);
                Ajouter_Modifier_SousFamille fenetremodif = new Ajouter_Modifier_SousFamille("Modification  Sous Famille ", refsousfamille);
                fenetremodif.ShowDialog(this);
                MettreJourSousFamilles();
                if (fenetremodif.Reussi)
                {
                    ChangementStatus("Une sous famille a été modifié");
                }
            }
        }


        /// <summary>
        ///     Cette méthode permet de supprimer une sous famille dans la base de données 
        /// </summary>
        /// <remarks>
        ///     la suppression est faite que si une ligne est sélectionnée , et un message box est affiché pour demander à l'utilisateur de confirmer la suppression
        ///     on met à jour la liste view des sous familles <see cref="ListView_SousFamille"/> , on change  le status de l'application si la suppression à reussi 
        /// </remarks>
        private void SupprimerSousFamille()
        {
            int count = this.ListView_SousFamille.Items.Count;
            DialogResult reponse = MessageBox.Show("Voulez-vous supprimer cette famille ? ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            string resultat;
            if (reponse == DialogResult.OK)
            {
                ListViewItem item = ListView_SousFamille.SelectedItems[0];
                int refsousfamille = Int32.Parse(item.SubItems[0].Text);
                InterfaceDB_Sous_Famille inter = new InterfaceDB_Sous_Famille();
                resultat= inter.SupprimerSousFamille(refsousfamille);
                MessageBox.Show(resultat, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MettreJourSousFamilles();
                if (count < ListView_SousFamille.Items.Count)
                {
                    ChangementStatus("Une sous famille supprimée ");
                }
            }
        }

        /// <summary>
        ///  Cette methode permet de gérer les évènements claviers
        /// -  F5 : pour mettre à jour la liste view <see cref="MettreJourSousFamilles"/>
        /// - Supp : pour supprimer une sous famille <see cref="SupprimerSousFamille"/>
        /// - Entrer : pour modifier une sous famille <see cref="ModifierSousFamille"/>
        ///  
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ListView_SousFamille_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                MettreJourSousFamilles();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                SupprimerSousFamille();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                ModifierSousFamille();
            }
        }

        /// <summary>
        ///  Cette methode permet de gerer l'évènement d'un clic droit en ouvrant un menu  <see cref="ContextMenu_OptionClicDroit"/> contenant des options d'ajout , suppression et de modification d'une sous famille
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ListView_SousFamille_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.ContextMenu_OptionClicDroit.Show(Cursor.Position);
            }
        }

        /// <summary>
        ///  Cette methode permet de gerer l'evènement double clic qui permet la modification d'une sous famille  <see cref="ModifierSousFamille"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ListView_SousFamille_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifierSousFamille();
        }

        /// <summary>
        ///  Cette methode gere l'évènement de clic sur l'option ajout du <see cref="ContextMenu_OptionClicDroit"/> pour ajouter une sous famille
        ///  gràce la fonction <see cref="AjouterSousFamille"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void AjouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterSousFamille();
        }

        /// <summary>
        ///  Cette methode gere l'évènement de clic sur l'option modifier du <see cref="ContextMenu_OptionClicDroit"/> pour modifier une sous famille
        ///  gràce la fonction <see cref="ModifierSousFamille"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierSousFamille();
        }

        /// <summary>
        ///  Cette methode gere l'évènement de clic sur l'option supprimer du <see cref="ContextMenu_OptionClicDroit"/> pour supprimer une sous famille
        ///  gràce la fonction <see cref="SupprimerSousFamille"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void SupprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerSousFamille();
        }

        /// <summary>
        /// Cette methode gere l'évènement de clic sur le bouton ajout de la barre d'outil pour ajouter une sous famille voir <see cref="AjouterSousFamille"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ToolStripButton_AjoutSousFamille_Click(object sender, EventArgs e)
        {
            AjouterSousFamille();
        }
    }
}
