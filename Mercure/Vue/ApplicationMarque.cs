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
    public partial class ApplicationMarque : Form
    {
        private ListViewColumnTri ColumnTri;

        private GestionGroupTri GroupTri;
    


        public ApplicationMarque()
        {
            InitializeComponent();
            RemplirListeMarque();
            ColumnTri = new ListViewColumnTri();
            this.listView_Marque.ListViewItemSorter = ColumnTri;
            GroupTri = new GestionGroupTri(listView_Marque);
        }

        public void MettreJourMarques()
        {
            listView_Marque.Items.Clear();
            listView_Marque.Columns.Clear();
            listView_Marque.Groups.Clear();
            listView_Marque.Clear();

            RemplirListeMarque();
        }

        public void RemplirListeMarque()
        {

            InterfaceDB_Marque inter = new InterfaceDB_Marque();
            int indice = 0;

            ColumnHeader Cref = new ColumnHeader();
            Cref.Text = "Ref Marque";
            Cref.Width = 80;


            ColumnHeader Cnom = new ColumnHeader();
            Cnom.Text = "Nom ";
            Cnom.Width = -2;


            this.listView_Marque.Columns.AddRange(new ColumnHeader[] { Cref, Cnom });

            List<Marque> liste = inter.GetToutesMarque();

            ListViewItem[] listeItem = new ListViewItem[liste.Count];

            foreach (Marque marque in liste)
            {
                string[] chaine = new string[] { marque.RefMarque.ToString(), marque.NomMarque };

                ListViewItem item = new ListViewItem(chaine);
                listeItem[indice] = item;
                indice++;
            }

            this.listView_Marque.Items.AddRange(listeItem);
        }
        private void ChangementStatus(string chaine)
        {
            this.statuslabel_operation.Text = chaine;
        }
        private void AjouterMarque()
        {
            int count = this.listView_Marque.Items.Count;
            Ajouter_Modifier_Marque ajout = new Ajouter_Modifier_Marque("Ajout Marque ");
            ajout.ShowDialog(this);
            MettreJourMarques();
            if (count < listView_Marque.Items.Count)
            {
                ChangementStatus("Une nouvelle marque ajoutée ");
            }
        }

        private void ModifierMarque()
        {
            if (listView_Marque.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_Marque.SelectedItems[0];
                int refmarque = Int32.Parse(item.SubItems[0].Text);
                Ajouter_Modifier_Marque fenetremodifMarque = new Ajouter_Modifier_Marque("Modification Marque ", refmarque);
                fenetremodifMarque.ShowDialog(this);
                MettreJourMarques();
            }
        }

        private void SupprimerMarque()
        {
            int count = this.listView_Marque.Items.Count;
            DialogResult reponse = MessageBox.Show("Voulez-vous supprimer cette marque ? ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            string resultat;
            if (reponse == DialogResult.OK)
            {
                ListViewItem item = listView_Marque.SelectedItems[0];
                int refmarque = Int32.Parse(item.SubItems[0].Text);
                InterfaceDB_Marque inter = new InterfaceDB_Marque();
                resultat= inter.SupprimerMarque(refmarque);
                MessageBox.Show(resultat, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MettreJourMarques();
                if (count > listView_Marque.Items.Count)
                {
                    ChangementStatus("Une marque supprimé  ");
                }
            }
        }

        private void listView_Marque_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenu_optionClicDroit.Show(Cursor.Position);
            }
        }

        private void listView_Marque_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifierMarque();
        }

        private void listView_Marque_KeyDown(object sender, KeyEventArgs e)
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

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterMarque();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierMarque();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerMarque();
        }

        private void toolStripButton_ajoutMarque_Click(object sender, EventArgs e)
        {
            AjouterMarque();
        }
    }
}
