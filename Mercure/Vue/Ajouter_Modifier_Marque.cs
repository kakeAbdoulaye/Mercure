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
    /// <summary>
    ///  Cette classe permet l'ajout et la modification d'une marque à travers une interface graphique contenant les champs à remplir  
    /// </summary>
    public partial class Ajouter_Modifier_Marque : Form
    {
        /// <summary>
        ///  Attribut contenant la reférence de la marque à modifier , il est egale à -1 si c'est pour l'ajout 
        /// </summary>
        private int RefMarque;

        /// <summary>
        ///     Constructeur pour un objet de type Ajouter_Modifier_Marque
        /// </summary>
        /// <param name="titre">le titre de la fenetre </param>
        /// <param name="refMarque"> la reférence de la marque , valeur par défaut = -1</param>
        /// <remarks>
        ///     - Si la reférence est égale à -1  , alors il s'agit de l'ajout d'une nouvelle marque 
        ///     - Sinon il s'agit d'une modification
        /// </remarks>
        public Ajouter_Modifier_Marque(string titre ,  int refMarque =-1)
        {
            InitializeComponent();
            this.Text = titre;
            RefMarque = refMarque;
            Init();
        }

        /// <summary>
        ///  Cette méthode permet d'initialiser l'interface graphique 
        /// </summary>
        public void Init()
        {
            if (RefMarque == -1)
            {

            }
            else
            {
                // Initialise les champs correspondant à la reférence de la marque( cas d'une modification)
                InterfaceDB_Marque inter = new InterfaceDB_Marque();
                Marque marque = inter.GetMarque(RefMarque);
                TextBox_NomMarque.Text = marque.NomMarque;
                Button_Ajouter_Modifier.Text = "Modifier";
            }
        }

        /// <summary>
        ///  Cette methode permet d'ajout ou de modifier une marqque après avoir cliqué sur le bouton ajouter / modifier
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        /// <remarks>
        ///     Cette methode vérifie que tous les champs sont saisie par l'utilisateur 
        ///     et choisie en fonction de l'attribut <see cref="RefMarque"/> si on ajoute ou modifie la marque  
        ///     puis on ferme la fenetre
        /// </remarks>
        private void Button_Ajouter_Modifier_Click(object sender, EventArgs e)
        {
            if ( String.IsNullOrEmpty(TextBox_NomMarque.Text))
            {
                MessageBox.Show(this, "Veillez remplir tous les champs !!!", "Erreur Insertion ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                InterfaceDB_Marque inter = new InterfaceDB_Marque();
                Marque marque = inter.GetMarque(TextBox_NomMarque.Text);
                string resultat;
                if (RefMarque == -1)//on ajoute
                {
                    resultat = inter.InsererMarque(TextBox_NomMarque.Text);

                }
                else // on modifie
                {

                    resultat = inter.ModifierMarque(RefMarque, TextBox_NomMarque.Text);

                }
                MessageBox.Show(this, resultat, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Console.WriteLine(resultat);
                this.Close();
            }
        }

        /// <summary>
        ///  Cette methode permet de fermer la fenetre après avoir cliquer sur le bouton annuler 
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void Button_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
