using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercure.InterfaceBaseDonnee;
using Mercure.Models;
namespace Mercure.Vue
{
    public partial class Ajouter_Modifier_Article : Form
    {
        private string refarticle;
        public Ajouter_Modifier_Article(string titre,string refArticle=null)
        {
            InitializeComponent();
            this.Text = titre;
            refarticle = refArticle;
            init();
        }
        public void init()
        {
            if (refarticle == null)
            {
                remplirComboMarque();
                remplirComboSousfamille();
            }
            else
            {
                InterfaceDB_Articles inter = new InterfaceDB_Articles();
                Article article = inter.getArticle(refarticle);
                textBox_refArticle.Text = refarticle;
                textBox_description.Text = article.Description;
                numericUpDown_prixht.Value = Decimal.Parse(article.PrixHT.ToString());
                numericUpDown_quantite.Value = Int32.Parse(article.Quantite.ToString());
                button_ajouter_modifier.Text = "Modifier";
                remplirComboMarque();
                remplirComboSousfamille();
                this.comboBox_marque.SelectedIndex = this.comboBox_marque.FindString(article.Marque.NomMarque);
                this.comboBox_sousfamille.SelectedIndex = this.comboBox_sousfamille.FindString(article.SousFamille.NomSousFamille);
            }
        }
        public void remplirComboSousfamille()
        {
            InterfaceDB_Sous_Famille inter = new InterfaceDB_Sous_Famille();
            int indice = 0;

            List<SousFamille> liste = inter.getToutesSousFamille();

            string[] chaine = new string[liste.Count];

            foreach (SousFamille sousfamille in liste)
            {
                chaine[indice] = sousfamille.NomSousFamille;
                indice++;
            }

            this.comboBox_sousfamille.Items.AddRange(chaine);
        }
        public void remplirComboMarque()
        {
            InterfaceDB_Marque inter = new InterfaceDB_Marque();
            int indice = 0;

            List<Marque> liste = inter.getToutesMarque();

            string[] chaine = new string[liste.Count];

            foreach (Marque marque in liste)
            {
                chaine[indice] = marque.NomMarque;
                indice++;
            }

            this.comboBox_marque.Items.AddRange(chaine);
        }

        private void button_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ajouter_modifier_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_refArticle.Text) || String.IsNullOrEmpty(comboBox_sousfamille.Text) || String.IsNullOrEmpty(comboBox_marque.Text) || String.IsNullOrEmpty(textBox_description.Text))
            {
                MessageBox.Show(this, "Veillez remplir tous les champs !!!", "Erreur Insertion ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                InterfaceDB_Articles inter = new InterfaceDB_Articles();
                InterfaceDB_Sous_Famille intersousfam = new InterfaceDB_Sous_Famille();
                InterfaceDB_Marque intermarque = new InterfaceDB_Marque();

                string resultat;

                SousFamille sousfamille = intersousfam.getSousFamille(comboBox_sousfamille.Text);
                Marque marque = intermarque.getMarque(comboBox_marque.Text);

                if (refarticle  == null )//on ajoute
                {
                    Article article = new Article(textBox_refArticle.Text, textBox_description.Text,sousfamille,marque, double.Parse(numericUpDown_prixht.Value.ToString()), Int32.Parse(numericUpDown_quantite.Value.ToString()));
                    resultat = inter.insererArticle(article);

                }
                else // on modifie
                {
                    
                    resultat = inter.modifierArticle(refarticle,textBox_description.Text,sousfamille.RefSousFamille,marque.RefMarque, double.Parse(numericUpDown_prixht.Value.ToString()), Int32.Parse(numericUpDown_quantite.Value.ToString()));

                }
                MessageBox.Show(this, resultat, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Console.WriteLine(resultat);
                this.Close();
            }
        }
    }
}
