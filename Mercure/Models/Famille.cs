using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.Models
{
    class Famille
    {
        private int refFamille;
        private string nomFamille;

        public Famille(int reffamille , string famille)
        {
            refFamille = reffamille;
            nomFamille = famille;
        }


        public int RefFamille
        {
            get
            {
                return refFamille;
            }

            set
            {
                refFamille = value;
            }
        }

        public string NomFamille
        {
            get
            {
                return nomFamille;
            }

            set
            {
                nomFamille = value;
            }
        }
    }
}
