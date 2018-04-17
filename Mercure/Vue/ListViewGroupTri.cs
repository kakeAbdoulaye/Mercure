using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercure.Vue
{
    /// <summary>
    ///  Cette classe permet le tri par groupe dans la liste view en fonction d'un ordre de trie 
    /// </summary>
    /// <remarks>
    ///     Elle étends la classe <see cref="IComparer"/>
    /// </remarks>
    class ListViewGroupTri : IComparer
    {
        /// <summary>
        /// Spécifie l'ordre de tri .
        /// </summary>
        private SortOrder OrdreTri_;
     
        /// <summary>
        ///  Constructeur 
        /// </summary>
        /// <param name="ordre"> ordre de trie des groupes </param>
        public ListViewGroupTri(SortOrder ordre)
        {
            OrdreTri = ordre;
        }

        /// <summary>
        /// Cette méthode est héritée de l'interface IComparer.  Il compare les deux objets passés en effectuant une comparaison 
        /// </summary>
        /// <param name="x">Premier objet à comparer</param>
        /// <param name="x">Deuxième objet à comparer</param>
        /// <returns>Le résultat de la comparaison.positif si équivalent, sinon négatif </returns>
        public int Compare(object x, object y)
        {
            int result = String.Compare( ((ListViewGroup)x).Header, ((ListViewGroup)y).Header);
            if (OrdreTri == SortOrder.Ascending)
            {
                return result;
            }
            else
            {
                return -result;
            }

        }

        /// <summary>
        ///  Cette propriété permet de retourner ou de modifier l'ordre de tri  
        /// </summary>
        public SortOrder OrdreTri
        {
            get
            {
                return OrdreTri_;
            }

            set
            {
                OrdreTri_ = value;
            }
        }

    }
}
