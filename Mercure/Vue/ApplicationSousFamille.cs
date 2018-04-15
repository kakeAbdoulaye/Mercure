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
    public partial class ApplicationSousFamille : Form
    {
        private ListViewColumnTri ColumnTri;

        private GestionGroupTri GroupTri;

        public ApplicationSousFamille()
        {
            InitializeComponent();
            RemplirListeSousFamille();
            ColumnTri = new ListViewColumnTri();
            this.listView_SousFamille.ListViewItemSorter = ColumnTri;
            GroupTri = new GestionGroupTri(listView_SousFamille);
        }

        public void MettreJourSousFamilles()
        {
            listView_SousFamille.Items.Clear();
            listView_SousFamille.Columns.Clear();
            listView_SousFamille.Groups.Clear();
            listView_SousFamille.Clear();

            RemplirListeSousFamille();
        }
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


            this.listView_SousFamille.Columns.AddRange(new ColumnHeader[] { Crefsousfamille, CrefFamille, Cnomsousfamille });

            List<SousFamille> listeSousfamille = interSousfamille.getToutesSousFamille();

            ListViewItem[] listeItem = new ListViewItem[listeSousfamille.Count];

            foreach (SousFamille sousfamille in listeSousfamille)
            {
                string[] chaine = new string[] { sousfamille.RefSousFamille.ToString(), sousfamille.MaFamille.NomFamille, sousfamille.NomSousFamille };

                ListViewItem item = new ListViewItem(chaine);
                listeItem[indice] = item;
                indice++;
            }

            this.listView_SousFamille.Items.AddRange(listeItem);

        }
        private void ChangementStatus(string chaine)
        {
            this.statuslabel_operation.Text = chaine;
        }

        private void AjouterSousFamille()
        {
            int count = this.listView_SousFamille.Items.Count;
            Ajouter_Modifier_SousFamille ajout = new Ajouter_Modifier_SousFamille("Ajout Sous Famille");
            ajout.ShowDialog(this);
            MettreJourSousFamilles();
            if(count < listView_SousFamille.Items.Count)
            {
                ChangementStatus("Une nouvelle sous famille ajoutée");
            }

        }
        private void ModifierSousFamille()
        {
            if (listView_SousFamille.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_SousFamille.SelectedItems[0];
                int refsousfamille = Int32.Parse(item.SubItems[0].Text);
                Ajouter_Modifier_SousFamille fenetremodif = new Ajouter_Modifier_SousFamille("Modification  Sous Famille ", refsousfamille);
                fenetremodif.ShowDialog(this);
                
                MettreJourSousFamilles();
            }
        }
        private void SupprimerSousFamille()
        {
            int count = this.listView_SousFamille.Items.Count;
            DialogResult reponse = MessageBox.Show("Voulez-vous supprimer cette famille ? ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            string resultat;
            if (reponse == DialogResult.OK)
            {
                ListViewItem item = listView_SousFamille.SelectedItems[0];
                int refsousfamille = Int32.Parse(item.SubItems[0].Text);
                InterfaceDB_Sous_Famille inter = new InterfaceDB_Sous_Famille();
                resultat= inter.SupprimerSousFamille(refsousfamille);
                MessageBox.Show(resultat, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MettreJourSousFamilles();
                if (count < listView_SousFamille.Items.Count)
                {
                    ChangementStatus("Une sous famille supprimée ");
                }
            }
        }
        private void listView_SousFamille_KeyDown(object sender, KeyEventArgs e)
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

        private void listView_SousFamille_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenu_optionClicDroit.Show(Cursor.Position);
            }
        }

        private void listView_SousFamille_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifierSousFamille();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterSousFamille();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierSousFamille();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerSousFamille();
        }

        private void toolStripButton_ajoutSousFamille_Click(object sender, EventArgs e)
        {
            AjouterSousFamille();
        }
    }
}
