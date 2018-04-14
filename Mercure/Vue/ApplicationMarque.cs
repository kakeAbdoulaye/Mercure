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
        private ListViewColumnTri columnTri;

        private GestionGroupTri groupTri;
    


        public ApplicationMarque()
        {
            InitializeComponent();
            remplirListeMarque();
            columnTri = new ListViewColumnTri();
            this.listView_Marque.ListViewItemSorter = columnTri;
            groupTri = new GestionGroupTri(listView_Marque);
        }

        public void mettreJourMarques()
        {
            listView_Marque.Items.Clear();
            listView_Marque.Columns.Clear();
            listView_Marque.Groups.Clear();
            listView_Marque.Clear();

            remplirListeMarque();
        }

        public void remplirListeMarque()
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

            List<Marque> liste = inter.getToutesMarque();

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
        private void changementStatus(string chaine)
        {
            this.statuslabel_operation.Text = chaine;
        }
        private void ajouterMarque()
        {
            int count = this.listView_Marque.Items.Count;
            Ajouter_Modifier_Marque ajout = new Ajouter_Modifier_Marque("Ajout Marque ");
            ajout.ShowDialog(this);
            mettreJourMarques();
            if (count < listView_Marque.Items.Count)
            {
                changementStatus("Une nouvelle marque ajoutée ");
            }
        }

        private void modifierMarque()
        {
            if (listView_Marque.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_Marque.SelectedItems[0];
                int refmarque = Int32.Parse(item.SubItems[0].Text);
                Ajouter_Modifier_Marque fenetremodifMarque = new Ajouter_Modifier_Marque("Modification Marque ", refmarque);
                fenetremodifMarque.ShowDialog(this);
                mettreJourMarques();
            }
        }

        private void supprimerMarque()
        {
            int count = this.listView_Marque.Items.Count;
            DialogResult reponse = MessageBox.Show("Voulez-vous supprimer cette marque ? ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            string resultat;
            if (reponse == DialogResult.OK)
            {
                ListViewItem item = listView_Marque.SelectedItems[0];
                int refmarque = Int32.Parse(item.SubItems[0].Text);
                InterfaceDB_Marque inter = new InterfaceDB_Marque();
                resultat= inter.supprimerMarque(refmarque);
                MessageBox.Show(resultat, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mettreJourMarques();
                if (count > listView_Marque.Items.Count)
                {
                    changementStatus("Une marque supprimé  ");
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
            modifierMarque();
        }

        private void listView_Marque_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                mettreJourMarques();
            }
            else if(e.KeyCode == Keys.Delete)
            {
                supprimerMarque();
            }
            else if(e.KeyCode == Keys.Enter)
            {
                modifierMarque();
            }
           
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouterMarque();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifierMarque();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supprimerMarque();
        }

        private void toolStripButton_ajoutMarque_Click(object sender, EventArgs e)
        {
            ajouterMarque();
        }
    }
}
