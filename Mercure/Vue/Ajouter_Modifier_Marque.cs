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
    public partial class Ajouter_Modifier_Marque : Form
    {
        private int refmarque;
        public Ajouter_Modifier_Marque(string titre ,  int refMarque =-1)
        {
            InitializeComponent();
            this.Text = titre;
            refmarque = refMarque;
            init();
        }
        public void init()
        {
            if (refmarque == -1)
            {

            }
            else
            {
                InterfaceDB_Marque inter = new InterfaceDB_Marque();
                Marque marque = inter.getMarque(refmarque);
                textBox_nommarque.Text = marque.NomMarque;
                button_ajouter_modifier.Text = "Modifier";
            }
        }
        private void textBox_refmarque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void button_ajouter_modifier_Click(object sender, EventArgs e)
        {
            if ( String.IsNullOrEmpty(textBox_nommarque.Text))
            {
                MessageBox.Show(this, "Veillez remplir tous les champs !!!", "Erreur Insertion ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                InterfaceDB_Marque inter = new InterfaceDB_Marque();
                Marque marque = inter.getMarque(textBox_nommarque.Text);
                string resultat;
                if (refmarque == -1)//on ajoute
                {
                    resultat = inter.insererMarque(textBox_nommarque.Text);

                }
                else // on modifie
                {

                    resultat = inter.modifierMarque(refmarque, textBox_nommarque.Text);

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
