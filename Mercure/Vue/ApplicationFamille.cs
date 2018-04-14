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
    public partial class ApplicationFamille : Form
    {
        private ListViewColumnTri columnTri;

        private GestionGroupTri groupTri;

        public ApplicationFamille()
        {
            InitializeComponent();
            remplirListeFamille();
            columnTri = new ListViewColumnTri();
            this.listView_Famille.ListViewItemSorter = columnTri;
            groupTri = new GestionGroupTri(listView_Famille);
        }

        public void mettreJourFamilles()
        {
            listView_Famille.Items.Clear();
            listView_Famille.Columns.Clear();
            listView_Famille.Groups.Clear();
            listView_Famille.Clear();

            remplirListeFamille();
        }

        public void remplirListeFamille()
        {
            InterfaceDB_Famille interfamille = new InterfaceDB_Famille();
            int indice = 0;

            ColumnHeader Creffamille = new ColumnHeader();
            Creffamille.Text = "RefFamille";
            Creffamille.Width = 80;

            ColumnHeader Cnom = new ColumnHeader();
            Cnom.Text = "Famille ";
            Cnom.Width = -2;

            this.listView_Famille.Columns.AddRange(new ColumnHeader[] { Creffamille, Cnom });
            List<Famille> listeFamille = interfamille.getToutesFamille();
            ListViewItem[] listeItemFamille = new ListViewItem[listeFamille.Count];

            foreach (Famille famille in listeFamille)
            {
                string[] chainefamille = new string[] { famille.RefFamille.ToString(), famille.NomFamille };

                ListViewItem itemfamille = new ListViewItem(chainefamille);
                listeItemFamille[indice] = itemfamille;
                indice++;
            }

            this.listView_Famille.Items.AddRange(listeItemFamille);

      
        }
        private void changementStatus(string chaine)
        {
            this.statuslabel_operation.Text = chaine;
        }

        public void ajouterFamille()
        {
            int count = this.listView_Famille.Items.Count;
            Ajouter_Modifier_Famille ajout = new Ajouter_Modifier_Famille("Ajout Famille ");
            ajout.ShowDialog(this);
            mettreJourFamilles();
            if(count < listView_Famille.Items.Count)
            {
                changementStatus("Une nouvelle famille ajoutée ");
            }
        }

        public void modifierFamille()
        {
            if (listView_Famille.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_Famille.SelectedItems[0];
                int reffamille = Int32.Parse(item.SubItems[0].Text);
                Ajouter_Modifier_Famille fenetremodif = new Ajouter_Modifier_Famille("Modification Famille ", reffamille);
                fenetremodif.ShowDialog(this);
                mettreJourFamilles();
            }
        }

        public void supprimerFamille()
        {
            int count = this.listView_Famille.Items.Count;
            DialogResult reponse = MessageBox.Show("Voulez-vous supprimer cette famille ? ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            string resultat = "";
            if (reponse == DialogResult.OK)
            {
                ListViewItem item = listView_Famille.SelectedItems[0];
                int reffamille = Int32.Parse(item.SubItems[0].Text);
                InterfaceDB_Famille inter = new InterfaceDB_Famille();               
                resultat= inter.supprimerFamille(reffamille);
                MessageBox.Show(resultat, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mettreJourFamilles();
                if (count > listView_Famille.Items.Count)
                {
                    changementStatus("Une famille supprimée");
                }
            }
        }

        private void listView_Famille_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.contextMenu_optionClicDroit.Show(Cursor.Position);
                }
            }
        }

        private void listView_Famille_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            modifierFamille();
        }

        private void listView_Famille_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                mettreJourFamilles();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                supprimerFamille();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                modifierFamille();
            }
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouterFamille();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifierFamille();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supprimerFamille();
        }

        private void toolStripButton_ajoutfamille_Click(object sender, EventArgs e)
        {
            ajouterFamille();
        }
    }
}
