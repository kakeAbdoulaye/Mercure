using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.Models
{
    class Marque
    {
        private int refMarque;
        private string nomMarque;

        public Marque(int refmarque , string marque)
        {
            refMarque = refmarque;
            nomMarque = marque;
        }

        public string NomMarque
        {
            get
            {
                return nomMarque;
            }

            set
            {
                nomMarque = value;
            }
        }

        public int RefMarque
        {
            get
            {
                return refMarque;
            }

            set
            {
                refMarque = value;
            }
        }
    }
}
