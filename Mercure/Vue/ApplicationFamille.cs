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
        private ListViewColumnTri ColumnTri;

        private GestionGroupTri GroupTri;

        public ApplicationFamille()
        {
            InitializeComponent();
            RemplirListeFamille();
            ColumnTri = new ListViewColumnTri();
            this.listView_Famille.ListViewItemSorter = ColumnTri;
            GroupTri = new GestionGroupTri(listView_Famille);
        }

        public void MettreJourFamilles()
        {
            listView_Famille.Items.Clear();
            listView_Famille.Columns.Clear();
            listView_Famille.Groups.Clear();
            listView_Famille.Clear();

            RemplirListeFamille();
        }

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

            this.listView_Famille.Columns.AddRange(new ColumnHeader[] { Creffamille, Cnom });
            List<Famille> listeFamille = interfamille.GetToutesFamille();
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
        private void ChangementStatus(string chaine)
        {
            this.statuslabel_operation.Text = chaine;
        }

        public void AjouterFamille()
        {
            int count = this.listView_Famille.Items.Count;
            Ajouter_Modifier_Famille ajout = new Ajouter_Modifier_Famille("Ajout Famille ");
            ajout.ShowDialog(this);
            MettreJourFamilles();
            if(count < listView_Famille.Items.Count)
            {
                ChangementStatus("Une nouvelle famille ajoutée ");
            }
        }

        public void ModifierFamille()
        {
            if (listView_Famille.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_Famille.SelectedItems[0];
                int reffamille = Int32.Parse(item.SubItems[0].Text);
                Ajouter_Modifier_Famille fenetremodif = new Ajouter_Modifier_Famille("Modification Famille ", reffamille);
                fenetremodif.ShowDialog(this);
                MettreJourFamilles();
            }
        }

        public void SupprimerFamille()
        {
            int count = this.listView_Famille.Items.Count;
            DialogResult reponse = MessageBox.Show("Voulez-vous supprimer cette famille ? ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            string resultat = "";
            if (reponse == DialogResult.OK)
            {
                ListViewItem item = listView_Famille.SelectedItems[0];
                int reffamille = Int32.Parse(item.SubItems[0].Text);
                InterfaceDB_Famille inter = new InterfaceDB_Famille();               
                resultat= inter.SupprimerFamille(reffamille);
                MessageBox.Show(resultat, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MettreJourFamilles();
                if (count > listView_Famille.Items.Count)
                {
                    ChangementStatus("Une famille supprimée");
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
            ModifierFamille();
        }

        private void listView_Famille_KeyDown(object sender, KeyEventArgs e)
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

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterFamille();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierFamille();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerFamille();
        }

        private void toolStripButton_ajoutfamille_Click(object sender, EventArgs e)
        {
            AjouterFamille();
        }
    }
}
