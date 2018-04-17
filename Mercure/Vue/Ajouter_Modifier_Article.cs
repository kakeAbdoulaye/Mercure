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
    ///  Cette classe permet l'ajout et la modification d'un article à travers une interface graphique contenant les champs à remplir  
    /// </summary>
    public partial class Ajouter_Modifier_Article : Form
    {
        /// <summary>
        ///  Attribut contenant la reférence de l'article à modifier , il est null si c'est pour l'ajout 
        /// </summary>
        private string RefArticle;

        /// <summary>
        ///     Constructeur pour un objet de type Ajouter_Modifier_Article
        /// </summary>
        /// <param name="titre">le titre de la fenetre </param>
        /// <param name="refArticle"> la reférence de l'article , valeur par défaut = null</param>
        /// <remarks>
        ///     - Si la reférence est à null , alors il s'agit de l'ajout d'un nouveau article 
        ///     - Sinon il s'agit d'une modification
        /// </remarks>
        public Ajouter_Modifier_Article(string titre,string refArticle=null)
        {
            InitializeComponent();
            this.Text = titre;
            RefArticle = refArticle;
            Init();
        }

        /// <summary>
        ///  Cette méthode permet d'initialiser l'interface graphique 
        /// </summary>
        public void Init()
        {
            if (RefArticle == null)
            {
                RemplirComboMarque();
                RemplirComboSousfamille();
            }
            else
            {
                // Initialise les champs correspondant à la reférence de l'article ( cas d'une modification)
                InterfaceDB_Articles inter = new InterfaceDB_Articles();
                Article article = inter.GetArticle(RefArticle);
                TextBox_RefArticle.Text = RefArticle;
                TextBox_Description.Text = article.Description;
                NumericUpDown_PrixHT.Value = Decimal.Parse(article.PrixHT.ToString());
                NumericUpDown_Quantite.Value = Int32.Parse(article.Quantite.ToString());
                Button_Ajouter_Modifier.Text = "Modifier";
                RemplirComboMarque();
                RemplirComboSousfamille();
                this.ComboBox_Marque.SelectedIndex = this.ComboBox_Marque.FindString(article.Marque.NomMarque);
                this.ComboBox_SousFamille.SelectedIndex = this.ComboBox_SousFamille.FindString(article.SousFamille.NomSousFamille);
            }
        }

        /// <summary>
        ///  Cette methode permet d'aller chercher dans la base de données Toutes les sous familles et remplir la liste Combobox pour les sous familles
        /// </summary>
        public void RemplirComboSousfamille()
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

            this.ComboBox_SousFamille.Items.AddRange(chaine);
        }

        /// <summary>
        ///  Cette methode permet d'aller chercher dans la base de données Toutes les marques et remplir la liste Combobox pour les marques
        /// </summary>
        public void RemplirComboMarque()
        {
            InterfaceDB_Marque inter = new InterfaceDB_Marque();
            int indice = 0;

            List<Marque> liste = inter.GetToutesMarque();

            string[] chaine = new string[liste.Count];

            foreach (Marque marque in liste)
            {
                chaine[indice] = marque.NomMarque;
                indice++;
            }

            this.ComboBox_Marque.Items.AddRange(chaine);
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

        /// <summary>
        ///  Cette methode permet d'ajout ou de modifier un article après avoir cliqué sur le bouton ajouter / modifier
        /// </summary>
        /// <param name="sender">object qui envoie l'action </param>
        /// <param name="e">Evenement envoyé </param>
        /// <remarks>
        ///     Cette methode vérifie que tous les champs sont saisie par l'utilisateur 
        ///     et choisie en fonction de l'attribut <see cref="RefArticle"/> si on ajoute ou modifie l'article 
        ///     puis on ferme la fenetre
        /// </remarks>
        private void Button_Ajouter_Modifier_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox_RefArticle.Text) || String.IsNullOrEmpty(ComboBox_SousFamille.Text) || String.IsNullOrEmpty(ComboBox_Marque.Text) || String.IsNullOrEmpty(TextBox_Description.Text))
            {
                MessageBox.Show(this, "Veillez remplir tous les champs !!!", "Erreur Insertion ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                InterfaceDB_Articles inter = new InterfaceDB_Articles();
                InterfaceDB_Sous_Famille intersousfam = new InterfaceDB_Sous_Famille();
                InterfaceDB_Marque intermarque = new InterfaceDB_Marque();

                string resultat;

                SousFamille sousfamille = intersousfam.GetSousFamille(ComboBox_SousFamille.Text);
                Marque marque = intermarque.GetMarque(ComboBox_Marque.Text);

                if (RefArticle  == null )//on ajoute
                {
                    Article article = new Article(TextBox_RefArticle.Text, TextBox_Description.Text,sousfamille,marque, double.Parse(NumericUpDown_PrixHT.Value.ToString()), Int32.Parse(NumericUpDown_Quantite.Value.ToString()));
                    resultat = inter.InsererArticle(article);

                }
                else // on modifie
                {
                    
                    resultat = inter.ModifierArticle(RefArticle,TextBox_Description.Text,sousfamille.RefSousFamille,marque.RefMarque, double.Parse(NumericUpDown_PrixHT.Value.ToString()), Int32.Parse(NumericUpDown_Quantite.Value.ToString()));

                }
                MessageBox.Show(this, resultat, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
        }
    }
}
