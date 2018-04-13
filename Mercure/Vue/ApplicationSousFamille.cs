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
        private ListViewColumnTri columnTri;

        private GestionGroupTri groupTri;

        public ApplicationSousFamille()
        {
            InitializeComponent();
            remplirListeSousFamille();
            columnTri = new ListViewColumnTri();
            this.listView_SousFamille.ListViewItemSorter = columnTri;
            groupTri = new GestionGroupTri(listView_SousFamille);
        }

        public void mettreJourSousFamilles()
        {
            listView_SousFamille.Items.Clear();
            listView_SousFamille.Columns.Clear();
            listView_SousFamille.Groups.Clear();
            listView_SousFamille.Clear();

            remplirListeSousFamille();
        }
        public void remplirListeSousFamille()
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

        private void ajouterSousFamille()
        {
            Ajouter_Modifier_SousFamille ajout = new Ajouter_Modifier_SousFamille("Ajout Sous Famille");
            ajout.ShowDialog(this);
        }
        private void modifierSousFamille()
        {
            if (listView_SousFamille.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_SousFamille.SelectedItems[0];
                int refsousfamille = Int32.Parse(item.SubItems[0].Text);
                Ajouter_Modifier_SousFamille fenetremodif = new Ajouter_Modifier_SousFamille("Modification  Sous Famille ", refsousfamille);
                fenetremodif.ShowDialog(this);
                
                mettreJourSousFamilles();
            }
        }
        private void supprimerSousFamille()
        {
            DialogResult reponse = MessageBox.Show("Voulez-vous supprimer cette famille ? ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (reponse == DialogResult.OK)
            {
                ListViewItem item = listView_SousFamille.SelectedItems[0];
                int refsousfamille = Int32.Parse(item.SubItems[0].Text);
                InterfaceDB_Sous_Famille inter = new InterfaceDB_Sous_Famille();
                inter.supprimerSousFamille(refsousfamille);
          
                mettreJourSousFamilles();
            }
        }
        private void listView_SousFamille_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                mettreJourSousFamilles();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                supprimerSousFamille();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                modifierSousFamille();
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
            modifierSousFamille();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouterSousFamille();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifierSousFamille();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supprimerSousFamille();
        }
    }
}
