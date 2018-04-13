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
    public partial class Ajouter_Modifier_Famille : Form
    {
        private int reffamille;
        public Ajouter_Modifier_Famille(string titre , int refFamille = -1)
        {
            InitializeComponent();
            this.Text = titre;
            reffamille = refFamille;
            init();
        }

        public void init()
        {
            if (reffamille == -1)
            {
                
            }
            else
            {
                InterfaceDB_Famille inter = new InterfaceDB_Famille();
                Famille famille = inter.getFamille(reffamille);
                textBox_nomfamille.Text = famille.NomFamille;
                button_ajouter_modifier.Text = "Modifier";
            }
        }
        private void textBox_reffamille_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void button_ajouter_modifier_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_nomfamille.Text))
            {
                MessageBox.Show(this, "Veillez remplir tous les champs !!!", "Erreur Insertion ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                InterfaceDB_Famille interfam = new InterfaceDB_Famille();
                Famille famille = interfam.getFamille(textBox_nomfamille.Text);
                string resultat;
                if (reffamille == -1)//on ajoute
                {
                    resultat = interfam.insererFamille(textBox_nomfamille.Text);

                }
                else // on modifie
                {

                    resultat = interfam.modifierFamille(reffamille, textBox_nomfamille.Text);

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
