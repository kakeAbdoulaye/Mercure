using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercure.Vue
{
    class ListViewGroupTri : IComparer
    {
        /// <summary>
        /// Spécifie l'ordre de tri .
        /// </summary>
        private SortOrder OrdreTri;



        public SortOrder OrdreTri1
        {
            get
            {
                return OrdreTri;
            }

            set
            {
                OrdreTri = value;
            }
        }

        public ListViewGroupTri()
        {
            OrdreTri = SortOrder.None;
        }
        public ListViewGroupTri(SortOrder ordre)
        {
            OrdreTri = ordre;
        }
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
    }
}
