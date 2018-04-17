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
    ///  Cette classe represente l'application de la marque , elle permet la gestion des marques 
    ///  , comme : 
    ///  
    ///  - L'affichage : 
    ///     - Des marques
    ///  - L'Ajout d'une marque
    ///  - La modification d'une marque 
    ///  - la suppresion d'une marque 
    ///  - Quitter l'application
    ///  - Un status pour afficher la dernière action 
    /// </summary>
    public partial class ApplicationMarque : Form
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
        /// Constructeur d'un objet de type ApplicationMarque
        /// </summary>
        public ApplicationMarque()
        {
            InitializeComponent();
            RemplirListeMarque();
            ColumnTri = new ListViewColumnTri();
            this.ListView_Marque.ListViewItemSorter = ColumnTri;
            GroupTri = new GestionGroupTri(ListView_Marque);
        }

        /// <summary>
        /// Cette methode permet de mettre à jour la liste view contenant les marques  
        /// </summary>
        /// <remarks>
        ///  On libère la liste view puis la remplie avec des nouvelles marques 
        /// </remarks>
        private void MettreJourMarques()
        {
            ListView_Marque.Clear();
            RemplirListeMarque();
        }

        /// <summary>
        ///  Cette methode permet d'aller chercher dans la base de données Toutes les marques et remplir la liste View de ces marques
        ///  , en indiquant les noms de colonne 
        /// </summary>
        private void RemplirListeMarque()
        {

            InterfaceDB_Marque inter = new InterfaceDB_Marque();
            int indice = 0;

            ColumnHeader Cref = new ColumnHeader();
            Cref.Text = "Ref Marque";
            Cref.Width = 80;


            ColumnHeader Cnom = new ColumnHeader();
            Cnom.Text = "Nom ";
            Cnom.Width = -2;


            this.ListView_Marque.Columns.AddRange(new ColumnHeader[] { Cref, Cnom });

            List<Marque> liste = inter.GetToutesMarque();

            ListViewItem[] listeItem = new ListViewItem[liste.Count];

            foreach (Marque marque in liste)
            {
                string[] chaine = new string[] { marque.RefMarque.ToString(), marque.NomMarque };

                ListViewItem item = new ListViewItem(chaine);
                listeItem[indice] = item;
                indice++;
            }

            this.ListView_Marque.Items.AddRange(listeItem);
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
        ///  Cette méthode permet d'ouvir une fenetre modale d'ajout d'une marque <see cref="Ajouter_Modifier_Marque"/>
        /// </summary>
        /// <remarks>
        ///     Après la fermeture de cette fenetre modale , on met à jour la liste view des marques <see cref="ListView_Marque"/>  et 
        ///     on change  le status de l'application si l'ajout à reussi 
        /// </remarks>
        private void AjouterMarque()
        {
            Ajouter_Modifier_Marque ajout = new Ajouter_Modifier_Marque("Ajout Marque ");
            ajout.ShowDialog(this);
            MettreJourMarques();
            if (ajout.Reussi == true)
            {
                ChangementStatus("Une nouvelle marque ajoutée ");
            }
        }

        /// <summary>
        /// Cette méthode permet l'ouverture d'une fenetre modale permettant la modification d'une marque <see cref="Ajouter_Modifier_Marque"/>
        /// </summary>
        /// <remarks>
        ///     la fenetre modale ne s'ouvre que si une ligne est sélectionnée , et la modification se base sur la colonne contenant la reférence de la marque
        ///     on met à jour la liste view des marques <see cref="ListView_Marque"/> , on change  le status de l'application si la modification à reussi 
        /// </remarks>
        private void ModifierMarque()
        {
            if (ListView_Marque.SelectedItems.Count > 0)
            {
                ListViewItem item = ListView_Marque.SelectedItems[0];
                int refmarque = Int32.Parse(item.SubItems[0].Text);
                Ajouter_Modifier_Marque fenetremodifMarque = new Ajouter_Modifier_Marque("Modification Marque ", refmarque);
                fenetremodifMarque.ShowDialog(this);
                MettreJourMarques();
                if (fenetremodifMarque.Reussi == true)
                {
                    ChangementStatus("Une marque a été modifié ");
                }
            }
        }

        /// <summary>
        ///     Cette méthode permet de supprimer une marque dans la base de données 
        /// </summary>
        /// <remarks>
        ///     la suppression est faite que si une ligne est sélectionnée , et un message box est affiché pour demander à l'utilisateur de confirmer la suppression
        ///     on met à jour la liste view des marques <see cref="ListView_Marque"/> , on change  le status de l'application si la suppression à reussi 
        /// </remarks>
        private void SupprimerMarque()
        {
            int count = this.ListView_Marque.Items.Count;
            DialogResult reponse = MessageBox.Show("Voulez-vous supprimer cette marque ? ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            string resultat;
            if (reponse == DialogResult.OK)
            {
                ListViewItem item = ListView_Marque.SelectedItems[0];
                int refmarque = Int32.Parse(item.SubItems[0].Text);
                InterfaceDB_Marque inter = new InterfaceDB_Marque();
                resultat= inter.SupprimerMarque(refmarque);
                MessageBox.Show(resultat, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MettreJourMarques();
                if (count > ListView_Marque.Items.Count)
                {
                    ChangementStatus("Une marque supprimé  ");
                }
            }
        }

        /// <summary>
        ///  Cette methode permet de gerer l'évènement d'un clic droit en ouvrant un menu  <see cref="ContextMenu_OptionClicDroit"/> contenant des options d'ajout , suppression et de modification d'une marque
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ListView_Marque_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.ContextMenu_OptionClicDroit.Show(Cursor.Position);
            }
        }

        /// <summary>
        ///  Cette methode permet de gerer l'evènement double clic qui permet la modification d'une marque  <see cref="ModifierMarque"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ListView_Marque_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifierMarque();
        }

        /// <summary>
        ///  Cette methode permet de gérer les évènements claviers
        /// -  F5 : pour mettre à jour la liste view <see cref="MettreJourMarques"/>
        /// - Supp : pour supprimer une marque <see cref="SupprimerMarque"/>
        /// - Entrer : pour modifier une marque <see cref="ModifierMarque"/>
        ///  
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ListView_Marque_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                MettreJourMarques();
            }
            else if(e.KeyCode == Keys.Delete)
            {
                SupprimerMarque();
            }
            else if(e.KeyCode == Keys.Enter)
            {
                ModifierMarque();
            }
           
        }

        /// <summary>
        ///  Cette methode gere l'évènement de clic sur l'option ajout du <see cref="ContextMenu_OptionClicDroit"/> pour ajouter une marque
        ///  gràce la fonction <see cref="AjouterMarque"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void AjouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterMarque();
        }

        /// <summary>
        ///  Cette methode gere l'évènement de clic sur l'option modifier du <see cref="ContextMenu_OptionClicDroit"/> pour modifier une marque
        ///  gràce la fonction <see cref="ModifierMarque"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierMarque();
        }

        /// <summary>
        ///  Cette methode gere l'évènement de clic sur l'option supprimer du <see cref="ContextMenu_OptionClicDroit"/> pour supprimer une marque
        ///  gràce la fonction <see cref="SupprimerMarque"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void SupprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerMarque();
        }

        /// <summary>
        /// Cette methode gere l'évènement de clic sur le bouton ajout de la barre d'outil pour ajouter une marque voir <see cref="AjouterMarque"/>
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void ToolStripButton_AjoutMarque_Click(object sender, EventArgs e)
        {
            AjouterMarque();
        }
    }
}
