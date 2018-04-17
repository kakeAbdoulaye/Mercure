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
    ///  Cette classe permet l'ajout et la modification d'une famille à travers une interface graphique contenant les champs à remplir  
    /// </summary>
    public partial class Ajouter_Modifier_Famille : Form
    {
        /// <summary>
        ///  Attribut contenant la reférence de la famille à modifier , il est égale à -1  si c'est pour l'ajout 
        /// </summary>
        private int RefFamille;

        /// <summary>
        ///     Constructeur pour un objet de type Ajouter_Modifier_Famille
        /// </summary>
        /// <param name="titre">le titre de la fenetre </param>
        /// <param name="refFamille"> la reférence de la famille , valeur par défaut = -1</param>
        /// <remarks>
        ///     - Si la reférence est à -1 , alors il s'agit de l'ajout d'une nouvelle famille 
        ///     - Sinon il s'agit d'une modification
        /// </remarks>
        public Ajouter_Modifier_Famille(string titre , int refFamille = -1)
        {
            InitializeComponent();
            this.Text = titre;
            RefFamille = refFamille;
            Init();
        }

        /// <summary>
        ///  Cette méthode permet d'initialiser l'interface graphique 
        ///  
        /// </summary>
        public void Init()
        {
            if (RefFamille == -1) // ajout
            {
                
            }
            else
            {
                // Initialise les champs correspondant à la reférence de la famille( cas d'une modification)
                InterfaceDB_Famille inter = new InterfaceDB_Famille();
                Famille famille = inter.GetFamille(RefFamille);
                TextBox_NomFamille.Text = famille.NomFamille;
                Button_Ajouter_Modifier.Text = "Modifier";
            }
        }


        /// <summary>
        ///  Cette methode permet d'ajout ou de modifier une famille après avoir cliqué sur le bouton ajouter / modifier
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        /// <remarks>
        ///     Cette methode vérifie que tous les champs sont saisie par l'utilisateur 
        ///     et choisie en fonction de l'attribut <see cref="RefFamille"/> si on ajoute ou modifie la famille 
        ///     puis on ferme la fenetre
        /// </remarks>
        private void Button_Ajouter_Modifier_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox_NomFamille.Text))
            {
                MessageBox.Show(this, "Veillez remplir tous les champs !!!", "Erreur Insertion ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                InterfaceDB_Famille interfam = new InterfaceDB_Famille();
                Famille famille = interfam.GetFamille(TextBox_NomFamille.Text);
                string resultat;
                if (RefFamille == -1)//on ajoute
                {
                    resultat = interfam.InsererFamille(TextBox_NomFamille.Text);

                }
                else // on modifie
                {

                    resultat = interfam.ModifierFamille(RefFamille, TextBox_NomFamille.Text);

                }
                MessageBox.Show(this, resultat, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Console.WriteLine(resultat);
                this.Close();
            }
        }

        /// <summary>
        ///  Cette methode permet de fermer la fenetre àprès avoir cliquer sur le bouton annuler 
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        private void Button_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
