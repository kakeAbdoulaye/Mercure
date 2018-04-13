using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.Models
{
    class Article
    {
        private string refArticle;
        private string description;
        private SousFamille sousFamille;
        private Marque marque;
        private double prixHT;
        private int quantite;
        public Article(string refarticle , string description,SousFamille sousfamille ,Marque marque , double prix , int quantite)
        {
            refArticle = refarticle;
            this.description = description;
            sousFamille = sousfamille;
            this.marque = marque;
            prixHT = prix;
            this.quantite = quantite;

        }
        public string RefArticle
        {
            get
            {
                return refArticle;
            }

            set
            {
                refArticle = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        internal SousFamille SousFamille
        {
            get
            {
                return sousFamille;
            }

            set
            {
                sousFamille = value;
            }
        }

        internal Marque Marque
        {
            get
            {
                return marque;
            }

            set
            {
                marque = value;
            }
        }

        public double PrixHT
        {
            get
            {
                return prixHT;
            }

            set
            {
                prixHT = value;
            }
        }

        public int Quantite
        {
            get
            {
                return quantite;
            }

            set
            {
                quantite = value;
            }
        }
    }
}
