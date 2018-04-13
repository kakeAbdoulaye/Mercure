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
    public partial class Ajouter_Modifier_SousFamille : Form
    {
        private int refsousfammile;
        public Ajouter_Modifier_SousFamille(string titre, int refsousFamille = -1)
        {
            InitializeComponent();
            this.Text = titre;
            this.refsousfammile = refsousFamille;
            init();
            
        }

        public void remplirComboFamille()
        {
            InterfaceDB_Famille inter = new InterfaceDB_Famille();
            int indice = 0;

            List<Famille> liste = inter.getToutesFamille();

            string[] chaine = new string[liste.Count];

            foreach (Famille famille in liste)
            {
                chaine[indice] = famille.NomFamille;
                indice++;
            }

            this.comboBox_typefamille.Items.AddRange(chaine);

        }
        public void init()
        {
            if (refsousfammile == -1)
            {
                remplirComboFamille();
            }
            else
            {
                InterfaceDB_Sous_Famille inter = new InterfaceDB_Sous_Famille();
                SousFamille sousfammille = inter.getSousFamille(refsousfammile);
                textBox_nomsousfamille.Text = sousfammille.NomSousFamille;
                button_ajouter_modifier.Text = "Modifier";
                remplirComboFamille();
                this.comboBox_typefamille.SelectedIndex = this.comboBox_typefamille.FindString(sousfammille.MaFamille.NomFamille);
            }
        }

        private void button_ajouter_modifier_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(textBox_nomsousfamille.Text) || String.IsNullOrEmpty(comboBox_typefamille.Text))
            {
                MessageBox.Show(this,"Veillez remplir tous les champs !!!" ,"Erreur Insertion ",MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {

                InterfaceDB_Sous_Famille inter = new InterfaceDB_Sous_Famille();
                InterfaceDB_Famille interfam = new InterfaceDB_Famille();
                Famille famille = interfam.getFamille(comboBox_typefamille.Text);
                string resultat;
                if (refsousfammile == -1)//on ajoute
                {
                    resultat = inter.insererSousFamille(famille.NomFamille, textBox_nomsousfamille.Text);
                   
                }
                else // on modifie
                {
                   
                    resultat = inter.modifierSousFamille(refsousfammile,famille.RefFamille, textBox_nomsousfamille.Text);
                    
                }
                MessageBox.Show(this, resultat, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Console.WriteLine(resultat);
                this.Close();
            }
        }

        private void button_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
