using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.Models
{
    /// <summary>
    ///  SousFamille , cette classe représente une sous famille d'un article dans la base de données
    /// </summary>
    /// <remarks>
    ///     Une sous famille est caractérisé par : 
    ///         - un identifiant unique d'une sous famille 
    ///         - une famille à la quelle elle appartient 
    ///         - le nom de la sous famille 
    ///         
    /// <see cref="Famille"/>
    /// </remarks>
    class SousFamille
    {
        /// <summary>
        ///  L'identifiant de la sous famille , type : entier 
        /// </summary>
        /// <see cref="int"/>
        private int RefSousFamille_;

        /// <summary>
        ///  La famille à la quelle appartient la sous famille , type : Famille
        /// </summary>
        /// <see cref="Famille"/>
        private Famille MaFamille_;

        /// <summary>
        ///  Le nom de la sous famille , type : chaine de caractere 
        /// </summary>
        /// <see cref="string"/>
        private string NomSousFamille_;

        /// <summary>
        ///     Constructeur  d'un objet  sous famille 
        /// </summary>
        /// <param name="refsousfamille"> l'identifiant de la sous famille </param>
        /// <param name="famille">la famille appartenante </param>
        /// <param name="nomsousfamille"> le nom de la sous famille </param>
        public SousFamille(int refsousfamille , Famille famille, string nomsousfamille)
        {
            RefSousFamille_ = refsousfamille;
            MaFamille_ = famille;
            NomSousFamille_ = nomsousfamille;
        }

        /// <summary>
        ///     Cette propriété correspond à l'identifiant de la sous famille 
        ///     qui  permet de modifier et retourner  l'identifiant 
        /// </summary>
        public int RefSousFamille
        {
            get
            {
                return RefSousFamille_;
            }

            set
            {
                RefSousFamille_ = value;
            }
        }

        /// <summary>
        ///     Cette propriété correspond à la famille à la quelle appartient la sous famille 
        ///     qui  permet de modifier et retourner  la famille 
        /// </summary>
        internal Famille MaFamille
        {
            get
            {
                return MaFamille_;
            }

            set
            {
                MaFamille_ = value;
            }
        }

        /// <summary>
        ///     Cette propriété correspond au nom de la sous famille 
        ///     qui  permet de modifier et retourner  le nom  
        /// </summary>
        public string NomSousFamille
        {
            get
            {
                return NomSousFamille_;
            }

            set
            {
                NomSousFamille_ = value;
            }
        }
    }
}
