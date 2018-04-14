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
    public partial class ApplicatioCentrale : Form
    {
        private ListViewColumnTri columnTri;
        private GestionGroupTri groupTri;

        public ApplicatioCentrale()
        {
            InitializeComponent();
            remplirListeArticle();
            columnTri = new ListViewColumnTri();
            listView_Articles.ListViewItemSorter = columnTri;
            groupTri = new GestionGroupTri(listView_Articles);
            
        }

        public void mettreJourArticles()
        {
            listView_Articles.Items.Clear();
            listView_Articles.Columns.Clear();
            listView_Articles.Groups.Clear();
            listView_Articles.Clear();

            remplirListeArticle();
        }

        public void remplirListeArticle()
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

            listView_Articles.Columns.AddRange(new ColumnHeader[] { Crefarcticle, Cdescription, Cfamille, Csousfamille, Cmarque, Cprix, Cquantite });

            List<Article> listeArticle = interArticle.getToutesArticle();

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
           

            this.listView_Articles.Items.AddRange(listeItemArticle);
        }

        private void ApplicatioCentrale_FormClosing(object sender, FormClosingEventArgs e)
        {
            InterfaceDB.deconnection();
        }

        private void changementStatus(string chaine)
        {
            this.statuslabel_operation.Text = chaine;
        }
        private void ajouterArticle()
        {
            int count = listView_Articles.Items.Count;
            Ajouter_Modifier_Article ajout = new Ajouter_Modifier_Article("Ajouter Article");
            ajout.ShowDialog(this);
            mettreJourArticles();
            if (count < listView_Articles.Items.Count)
            {
                changementStatus("Un nouvel article ajouté ");
            }
        }

        private void modifierArticle()
        {
            if (listView_Articles.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_Articles.SelectedItems[0];
                string refarticle = item.SubItems[0].Text;
                Ajouter_Modifier_Article fenetremodifArticle = new Ajouter_Modifier_Article("Modification Article ", refarticle);
                fenetremodifArticle.ShowDialog(this);
                mettreJourArticles();
            }
        }

        private void supprimerArticle()
        {
            int count = listView_Articles.Items.Count;
            if (listView_Articles.SelectedItems.Count > 0)
            {
                DialogResult reponse = MessageBox.Show("Voulez-vous supprimer cet article ? ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (reponse == DialogResult.OK)
                {
                    ListViewItem item = listView_Articles.SelectedItems[0];
                    string refarticle = item.SubItems[0].Text;
                    InterfaceDB_Articles inter = new InterfaceDB_Articles();
                    inter.supprimerArticle(refarticle);
                    mettreJourArticles();
                    if (count > listView_Articles.Items.Count)
                    {
                        changementStatus("Un  article supprimé ");
                    }
                }

            }
        }

        private void listView_Articles_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenu_optionClicDroit.Show(Cursor.Position);
            }
        }
     
        private void listView_Articles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            modifierArticle();
        }

        private void listView_Articles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                mettreJourArticles();

            }
            else if (e.KeyCode == Keys.Delete)
            {
                supprimerArticle();
                
            }
            else if (e.KeyCode == Keys.Enter)
            {
                modifierArticle();
            }
        }
       
        private void afficherFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationFamille appli = new ApplicationFamille();
            appli.ShowDialog(this);
            mettreJourArticles();
        }

        private void ajouterFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Modifier_Famille appli = new Ajouter_Modifier_Famille("Ajouter Famille");
            appli.ShowDialog(this);
            mettreJourArticles();
        }

        private void afficherSousFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationSousFamille appli = new ApplicationSousFamille();
            appli.ShowDialog(this);
            mettreJourArticles();
        }

        private void ajouterSousFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Modifier_SousFamille appli = new Ajouter_Modifier_SousFamille("Ajouter Sous Famille");
            appli.ShowDialog(this);
            mettreJourArticles();
        }

        private void afficherMarqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationMarque appli = new ApplicationMarque();
            appli.ShowDialog(this);
            mettreJourArticles();
        }

        private void ajouterMarqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Modifier_Marque appli = new Ajouter_Modifier_Marque("Ajouter Marque");
            appli.ShowDialog(this);
            mettreJourArticles();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fenetre_Integration integration = new Fenetre_Integration();
            integration.ShowDialog(this);
            mettreJourArticles();
        }

        private void ajouterToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ajouterArticle();
            mettreJourArticles();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifierArticle();
            mettreJourArticles();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supprimerArticle();
            mettreJourArticles();
        }

        private void toolStripButton_ajoutArticle_Click(object sender, EventArgs e)
        {
            ajouterArticle();
            mettreJourArticles();
        }
        private void quitterApplication()
        {
            DialogResult reponse = MessageBox.Show("Voulez-vous vraiment quitté ? ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (reponse == DialogResult.OK)
            {
                InterfaceDB.deconnection();
                this.Close();
            }
               
        }
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quitterApplication();
        }

        private void toolStripButton_quitterApplication_Click(object sender, EventArgs e)
        {
            quitterApplication();
        }
    }
}

