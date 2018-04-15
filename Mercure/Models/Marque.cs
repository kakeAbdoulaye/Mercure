using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.Models
{
    /// <summary>
    ///     Cette classe représente une marque d'article  dans la base de données
    ///     
    /// </summary>
    /// <remarks>
    ///     Une marque est caractérisé par : 
    ///      - un identifiant unique , attribué à une marque 
    ///      - un nom de marque 
    /// </remarks>
    class Marque
    {
        /// <summary>
        ///  L'identifiant de la marque , type : entier 
        /// </summary>
        /// <see cref="int"/> 
        private int RefMarque_;


        /// <summary>
        /// Le nom de la marque , type : chaine de caractère 
        /// </summary>
        /// <see cref="string"/>
        private string NomMarque_;


        /// <summary>
        ///     Constructeur d'un objet Marque  , qui initialise les attributs de la classe
        /// </summary>
        /// <param name="refmarque"> l'identifiant unique de la marque </param>
        /// <param name="marque">le nom de la marque </param>
        public Marque(int refmarque , string marque)
        {
            RefMarque_ = refmarque;
            NomMarque_ = marque;
        }

        /// <summary>
        ///     Cette propriété correspond à celui du nom de la marque 
        ///     qui lui permet de modifier le nom , et retourner le nom 
        /// </summary>
        public string NomMarque
        {
            get
            {
                return NomMarque_;
            }

            set
            {
                NomMarque_ = value;
            }
        }


        /// <summary>
        ///     Cette propriété correspond à celui de l'identifiant de la marque 
        ///     qui lui permet de modifier l'identifiant , et retourner le l'identifiant 
        /// </summary>
        public int RefMarque
        {
            get
            {
                return RefMarque_;
            }

            set
            {
                RefMarque_ = value;
            }
        }
    }
}
