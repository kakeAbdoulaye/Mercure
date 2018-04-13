using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercure.Vue
{
    class ListViewColumnTri : IComparer
    {
        /// <summary>
        /// Spécifie la colonne à trier
        /// </summary>
        private int columnATrier;

        /// <summary>
        /// Spécifie l'ordre de tri .
        /// </summary>
        private SortOrder ordreTri;

        /// <summary>
        /// Objet de comparaison ne respectant pas les majuscules et minuscules
        /// </summary>
        private CaseInsensitiveComparer ObjectCompare;

        public int ColumnATrier
        {
            get
            {
                return columnATrier;
            }

            set
            {
                columnATrier = value;
            }
        }

        public SortOrder OrdreTri
        {
            get
            {
                return ordreTri;
            }

            set
            {
                ordreTri = value;
            }
        }

        public ListViewColumnTri()
        {
            ColumnATrier = 0;
            OrdreTri = SortOrder.None;
            ObjectCompare = new CaseInsensitiveComparer();
        }
        public ListViewColumnTri(SortOrder ordre)
        {
            ColumnATrier = 0;
            OrdreTri = ordre;
            ObjectCompare = new CaseInsensitiveComparer();
        }


        /// <summary>
        /// Cette méthode est héritée de l'interface IComparer.  Il compare les deux objets passés en effectuant une comparaison 
        ///qui ne tient pas compte des majuscules et des minuscules.
        /// </summary>
        /// <param name="x">Premier objet à comparer</param>
        /// <param name="x">Deuxième objet à comparer</param>
        /// <returns>Le résultat de la comparaison. "0" si équivalent, négatif si 'x' est inférieur à 'y' 
        ///et positif si 'x' est supérieur à 'y'</returns>
        public int Compare(object x, object y)
        {
            int compareResult;
            ListViewItem listviewX, listviewY;

            // Envoit les objets à comparer aux objets ListViewItem
            listviewX = (ListViewItem)x;
            listviewY = (ListViewItem)y;

            // Compare les deux éléments
            compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnATrier].Text, listviewY.SubItems[ColumnATrier].Text);

            // Calcule la valeur correcte d'après la comparaison d'objets
            if (OrdreTri == SortOrder.Ascending)
            {
                // Le tri croissant est sélectionné, renvoie des résultats normaux de comparaison
                return compareResult;
            }
            else if (OrdreTri == SortOrder.Descending)
            {
                // Le tri décroissant est sélectionné, renvoie des résultats négatifs de comparaison
                return (-compareResult);
            }
            else
            {
                // Renvoie '0' pour indiquer qu'ils sont égaux
                return 0;
            }
        }

       

    }
}







