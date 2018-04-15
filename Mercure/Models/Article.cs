using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.Models
{
    /// <summary>
    /// Cette classe permet de modéliser et représenter un article 
    /// </summary>
    /// <remarks>
    ///     Chaque attributs représente un champ dans la table Articles dans la base de données
    ///     Elle est caractérisé par :  
    ///         - un identifiant unique de l'article
    ///         - une description de l'article 
    ///         - La sous famille de l'article
    ///         - La marque de l'article 
    ///         - le prix de l'article 
    ///         - la quantité disponible de cet article 
    ///         
    /// </remarks>
    /// <see cref="SousFamille"/>
    /// <see cref="Marque"/>
    class Article
    {
        /// <summary>
        ///  l'identifiant de l'article , type : chaine de caractère 
        /// </summary>
        /// <see cref="string"/>
        private string RefArticle_;

        /// <summary>
        /// la description de l'article ,  type : chaine de caractère 
        /// </summary>
        /// <see cref="string"/>
        private string Description_;

        /// <summary>
        ///  La sous famille de l'article , type : SousFamille 
        /// </summary>
        /// <see cref="SousFamille"/>
        private SousFamille SousFamille_;

        /// <summary>
        /// La marque de l'article 
        /// </summary>
        /// <see cref="Marque"/>
        private Marque Marque_;

        /// <summary>
        ///  le prix de l'article 
        /// </summary>
        /// <see cref="double"/>
        private double PrixHT_;

        /// <summary>
        ///  La quantité d'un article 
        /// </summary>
        /// <see cref=" int "/>
        private int Quantite_;

        /// <summary>
        ///  Constructeur d'un objet Article
        /// </summary>
        /// <param name="refarticle"> identifiant de l'article </param>
        /// <param name="description">la description de l'article </param>
        /// <param name="sousfamille">la sous famille de l'article </param>
        /// <param name="marque">la marque de l'article </param>
        /// <param name="prix"> le prix de l'article </param>
        /// <param name="quantite">la quantité  de l'article </param>
        public Article(string refarticle , string description,SousFamille sousfamille ,Marque marque , double prix , int quantite)
        {
            RefArticle_ = refarticle;
            Description_ = description;
            SousFamille_ = sousfamille;
            Marque_ = marque;
            PrixHT_ = prix;
            Quantite_ = quantite;

        }

        /// <summary>
        ///     Cette propriété correspond à celui de l'identifiant de l'article
        ///     qui lui permet de modifier l'identifiant , et retourner le l'identifiant 
        /// </summary>
        public string RefArticle
        {
            get
            {
                return RefArticle_;
            }

            set
            {
                RefArticle_ = value;
            }
        }

        /// <summary>
        ///     Cette propriété correspond à celui de la description de l'article 
        ///     qui lui permet de modifier la description , et retourner la description
        /// </summary>
        public string Description
        {
            get
            {
                return Description_;
            }

            set
            {
                Description_ = value;
            }
        }

        /// <summary>
        ///     Cette propriété correspond à celui de la sous famille de l'article 
        ///     qui lui permet de modifier la sous famille , et retourner la sous famille
        /// </summary>
        internal SousFamille SousFamille
        {
            get
            {
                return SousFamille_;
            }

            set
            {
                SousFamille_ = value;
            }
        }

        /// <summary>
        ///     Cette propriété correspond à celui de la marque de l'article 
        ///     qui lui permet de modifier la marque , et retourner la marque
        /// </summary>
        internal Marque Marque
        {
            get
            {
                return Marque_;
            }

            set
            {
                Marque_ = value;
            }
        }

        /// <summary>
        ///     Cette propriété correspond à celui du prix de l'artcile 
        ///     qui lui permet de modifier le prix , et retourner le prix
        /// </summary>
        public double PrixHT
        {
            get
            {
                return PrixHT_;
            }

            set
            {
                PrixHT_ = value;
            }
        }

        /// <summary>
        ///     Cette propriété correspond à celui de la quantite de l'article 
        ///     qui lui permet de modifier la quantite , et retourner la quantite
        /// </summary>
        public int Quantite
        {
            get
            {
                return Quantite_;
            }

            set
            {
                Quantite_ = value;
            }
        }
    }
}
