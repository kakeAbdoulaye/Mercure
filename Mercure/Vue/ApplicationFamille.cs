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
    ///  Cette classe represente l'application de la famille, elle permet la gestion des familles 
    ///  , comme : 
    ///  
    ///  - L'affichage : 
    ///     - Des familles
    ///  - L'Ajout d'une Famille
    ///  - La modification d'une famille 
    ///  - la suppresion d'une famille 
    ///  - Quitter l'application
    ///  - Un status pour afficher la dernière action 
    /// </summary>
    public partial class ApplicationFamille : Form
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
        /// Constructeur d'un objet de type ApplicationFamille
        /// </summary>
        public ApplicationFamille()
        {
            InitializeComponent();
            RemplirListeFamille();
            ColumnTri = new ListViewColumnTri();
            this.ListView_Famille.ListViewItemSorter = ColumnTri;
            GroupTri = new GestionGroupTri(ListView_Famille);
        }


        /// <summary>
        /// Cette methode permet de mettre à jour la liste view contenant les familles  
        /// </summary>
        /// <remarks>
        ///  On libère la liste view puis la remplie avec des nouvelles familles 
        /// </remarks>
        public void MettreJourFamilles()
        {
            ListView_Famille.Clear();
            RemplirListeFamille();
        }

        /// <summary>
        ///  Cette methode permet d'aller chercher dans la base de données Toutes les familles et remplir la liste View de ces familles
        ///  , en indiquant les noms de colonne 
        /// </summary>
        public void RemplirListeFamille()
        {
            InterfaceDB_Famille interfamille = new InterfaceDB_Famille();
            int indice = 0;

            ColumnHeader Creffamille = new ColumnHeader();
            Creffamille.Text = "RefFamille";
            Creffamille.Width = 80;

            ColumnHeader Cnom = new ColumnHeader();
            Cnom.Text = "Famille ";
            Cnom.Width = -2;

            this.ListView_Famille.Columns.AddRange(new ColumnHeader[] { Creffamille, Cnom });
            List<Famille> listeFamille = interfamille.GetToutesFamille();
            ListViewItem[] listeItemFamille = new ListViewItem[listeFamille.Count];

            foreach (Famille famille in listeFamille)
            {
                string[] chainefamille = new string[] { famille.RefFamille.ToString(), famille.NomFamille };

                ListViewItem itemfamille = new ListViewItem(chainefamille);
                listeItemFamille[indice] = itemfamille;
                indice++;
            }

            this.ListView_Famille.Items.AddRange(listeItemFamille);

      
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
        ///  Cette méthode permet d'ouvir une fenetre modale d'ajout d'une famille <see cref="Ajouter_Modifier_Famille"/>
        /// </summary>
        /// <remarks>
        ///     Après la fermeture de cette fenetre modale , on met à jour la liste view des familles <see cref="ListView_Famille"/>  et 
        ///     on change  le status de l'application si l'ajout à reussi 
        /// </remarks>
        public void AjouterFamille()
        {
            Ajouter_Modifier_Famille ajout = new Ajouter_Modifier_Famille("Ajout Famille ");
            ajout.ShowDialog(this);
            MettreJourFamilles();
            if(ajout.Reussi == true)
            {
                ChangementStatus("Une nouvelle famille ajoutée ");
            }
        }

        /// <summary>
        /// Cette méthode permet l'ouverture d'une fenetre modale permettant la modification d'une famille <see cref="Ajouter_Modifier_Famille"/>
        /// </summary>
        /// <remarks>
        ///     la fenetre modale ne s'ouvre que si une ligne est sélectionnée , et la modification se base sur la colonne contenant la reférence de la famille
        ///     on met à jour la liste view des familles <see cref="ListView_Famille"/> , on change  le status de l'application si la modification à reussi 
        /// </remarks>
        public void ModifierFamille()
        {
            if (ListView_Famille.SelectedItems.Count > 0)
            {
                ListViewItem item = ListView_Famille.SelectedItems[0];
                int reffamille = Int32.Parse(item.SubItems[0].Text);
                Ajouter_Modifier_Famille fenetremodif = new Ajouter_Modifier_Famille("Modification Famille ", reffamille);
                fenetremodif.ShowDialog(this);
                MettreJourFamilles();
                if (fenetremodif.Reussi == true)
                {
                    ChangementStatus("Une famille a été modifié");
                }
            }
        }

        /// <summary>
        ///     Cette méthode permet de supprimer une famille dans la base de données 
        /// </summary>
        /// <remarks>
        ///     la suppression est faite que si une ligne est sélectionnée , et un message box est affiché pour demander à l'utilisateur de confirmer la suppression
        ///     on met à jour la liste view des familles <see cref="ListView_Famille"/> , on change  le status de l'application si la suppression à reussi 
        /// </remarks>
        public void SupprimerFamille()
        {
            int count = this.ListView_Famille.Items.Count;
            DialogResult reponse = MessageBox.Show("Voulez-vous supprimer cette famille ? ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            string resultat = "";
            if (reponse == DialogResult.OK)
            {
                ListViewItem item = ListView_Famille.SelectedItems[0];
                int reffamille = Int32.Parse(item.SubItems[0].Text);
                InterfaceDB_Famille inter = new InterfaceDB_Famille();               
                resultat= inter.SupprimerFamille(reffamille);
                MessageBox.Show(resultat, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MettreJourFamilles();
                if (count > ListView_Famille.Items.Count)
                {
                    ChangementStatus("Une famille supprimée");
                }
            }
        }

        /// <summary>
        ///  Cette methode permet de gerer l'évènement d'un clic droit en ouvrant un menu  <see cref="ContextMenu_OptionClicDroit"/> contenant des options d'ajout , suppression et de modification d'une famille
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ListView_Famille_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
               this.ContextMenu_OptionClicDroit.Show(Cursor.Position);
            }
        }

        /// <summary>
        ///  Cette methode permet de gerer l'evènement double clic qui permet la modification d'une famille  <see cref="ModifierFamille"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ListView_Famille_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifierFamille();
        }

        /// <summary>
        ///  Cette methode permet de gérer les évènements claviers
        /// -  F5 : pour mettre à jour la liste view <see cref="MettreJourFamilles"/>
        /// - Supp : pour supprimer une famille <see cref="SupprimerFamille"/>
        /// - Entrer : pour modifier une famille <see cref="ModifierFamille"/>
        ///  
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ListView_Famille_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                MettreJourFamilles();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                SupprimerFamille();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                ModifierFamille();
            }
        }

        /// <summary>
        ///  Cette methode gere l'évènement de clic sur l'option ajout du <see cref="ContextMenu_OptionClicDroit"/> pour ajouter une famille
        ///  gràce la fonction <see cref="AjouterFamille"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void AjouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterFamille();
        }

        /// <summary>
        ///  Cette methode gere l'évènement de clic sur l'option modifier du <see cref="ContextMenu_OptionClicDroit"/> pour modifier une famille
        ///  gràce la fonction <see cref="ModifierFamille"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierFamille();
        }

        /// <summary>
        ///  Cette methode gere l'évènement de clic sur l'option supprimer du <see cref="ContextMenu_OptionClicDroit"/> pour supprimer une famille
        ///  gràce la fonction <see cref="SupprimerFamille"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void SupprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerFamille();
        }

        /// <summary>
        /// Cette methode gere l'évènement de clic sur le bouton ajout de la barre d'outil pour ajouter une famille voir <see cref="AjouterFamille"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ToolStripButton_AjoutFamille_Click(object sender, EventArgs e)
        {
            AjouterFamille();
        }
    }
}
