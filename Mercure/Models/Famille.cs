using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.Models
{
    /// <summary>
    ///     Famille est la classe représentant une famille d'article dans la base de données
    /// </summary>
    /// <remarks>
    ///     Une famille est caractérisé par : 
    ///      - un identifiant unique 
    ///      - un nom de famille 
    /// </remarks>
    class Famille
    {
        /// <summary>
        ///  l'identifiant d'une famille , type entier 
        /// </summary>
        /// <see cref="int"/>
        private int RefFamille_;

        /// <summary>
        /// le nom de la famille , type chaine de caractère 
        /// </summary>
        /// <see cref="string"/>
        private string NomFamille_;

        /// <summary>
        ///     Contructeur d'un objet Famille, qui permet d'instancier les attributs de la classe 
        /// </summary>
        /// <param name="reffamille"> l'identifiant unique d'une famille </param>
        /// <param name="famille">le nom d'une famille </param>
        public Famille(int reffamille , string famille)
        {
            RefFamille_ = reffamille;
            NomFamille = famille;
        }

        /// <summary>
        ///  Cette propriété correspond à celui de l'identifiant de la famille 
        ///  qui permet de retourner l'identifiant et de le modifier 
        /// </summary>
        public int RefFamille
        {
            get
            {
                return RefFamille_;
            }

            set
            {
                RefFamille_ = value;
            }
        }

        /// <summary>
        ///  Cette propriété correspond à celui du nom de la famille 
        ///  permettant sa modification et retour du nom 
        /// </summary>
        public string NomFamille
        {
            get
            {
                return NomFamille_;
            }

            set
            {
                NomFamille_ = value;
            }
        }
    }
}
