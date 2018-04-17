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
    ///  Cette classe permet l'ajout et la modification d'une sous famille à travers une interface graphique contenant les champs à remplir  
    /// </summary>
    public partial class Ajouter_Modifier_SousFamille : Form
    {
        /// <summary>
        ///  Attribut contenant la reférence de la sous famille à modifier , il est égale à -1 si c'est pour l'ajout 
        /// </summary>
        private int RefSousFamile;


        /// <summary>
        ///  Attribut permettant de savoir s'il y a eu ajout ou modification , par défaut false 
        /// </summary>
        private bool Reussi_ = false;

        /// <summary>
        ///  Cette propriété permet d'avoir l'etat de l'opération l'ajout / modification 
        /// </summary>
        public bool Reussi
        {
            get
            {
                return Reussi_;
            }
        }

        /// <summary>
        ///     Constructeur pour un objet de type Ajouter_Modifier_SousFamille
        /// </summary>
        /// <param name="titre">le titre de la fenetre </param>
        /// <param name="refsousFamille"> la reférence de la sous famille , valeur par défaut = -1</param>
        /// <remarks>
        ///     - Si la reférence est à -1 , alors il s'agit de l'ajout d'une nouvelle sous famille 
        ///     - Sinon il s'agit d'une modification
        /// </remarks>
        public Ajouter_Modifier_SousFamille(string titre, int refsousFamille = -1)
        {
            InitializeComponent();
            this.Text = titre;
            this.RefSousFamile = refsousFamille;
            Init();
            
        }

        /// <summary>
        ///  Cette methode permet d'aller chercher dans la base de données Toutes les familles et remplir la liste Combobox pour les familles
        /// </summary>
        public void RemplirComboFamille()
        {
            InterfaceDB_Famille inter = new InterfaceDB_Famille();
            int indice = 0;

            List<Famille> liste = inter.GetToutesFamille();

            string[] chaine = new string[liste.Count];

            foreach (Famille famille in liste)
            {
                chaine[indice] = famille.NomFamille;
                indice++;
            }

            this.ComboBox_TypeFamille.Items.AddRange(chaine);

        }

        /// <summary>
        ///  Cette méthode permet d'initialiser l'interface graphique 
        /// </summary>
        public void Init()
        {
            if (RefSousFamile == -1)
            {
                RemplirComboFamille();
            }
            else
            {
                // Initialise les champs correspondant à la reférence de la sous famille ( cas d'une modification)
                InterfaceDB_Sous_Famille inter = new InterfaceDB_Sous_Famille();
                SousFamille sousfammille = inter.GetSousFamille(RefSousFamile);
                TextBox_NomSousFamille.Text = sousfammille.NomSousFamille;
                Button_Ajouter_Modifier.Text = "Modifier";
                RemplirComboFamille();
                this.ComboBox_TypeFamille.SelectedIndex = this.ComboBox_TypeFamille.FindString(sousfammille.MaFamille.NomFamille);
            }
        }

        /// <summary>
        ///  Cette methode permet d'ajout ou de modifier une sous famille après avoir cliqué sur le bouton ajouter / modifier
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        /// <remarks>
        ///     Cette methode vérifie que tous les champs sont saisie par l'utilisateur 
        ///     et choisie en fonction de l'attribut <see cref="RefSousFamile"/> si on ajoute ou modifie la sous famille 
        ///     puis on ferme la fenetre
        /// </remarks>
        private void Button_Ajouter_Modifier_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(TextBox_NomSousFamille.Text) || String.IsNullOrEmpty(ComboBox_TypeFamille.Text))
            {
                MessageBox.Show(this,"Veillez remplir tous les champs !!!" ,"Erreur Insertion ",MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {

                InterfaceDB_Sous_Famille inter = new InterfaceDB_Sous_Famille();
                InterfaceDB_Famille interfam = new InterfaceDB_Famille();
                Famille famille = interfam.GetFamille(ComboBox_TypeFamille.Text);
                string resultat;
                if (RefSousFamile == -1)//on ajoute
                {
                    resultat = inter.InsererSousFamille(famille.NomFamille, TextBox_NomSousFamille.Text);
                   
                }
                else // on modifie
                {
                   
                    resultat = inter.ModifierSousFamille(RefSousFamile,famille.RefFamille, TextBox_NomSousFamille.Text);
                    
                }
                MessageBox.Show(this, resultat, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Reussi_ = true;
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
            Reussi_ = false;
            this.Close();
        }

    }
}
