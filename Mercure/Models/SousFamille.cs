using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.Models
{
    class SousFamille
    {
        private int refSousFamille;
        private Famille maFamille;
        private string nomSousFamille;

        public SousFamille(int refsousfamille , Famille famille, string nomsousfamille)
        {
            refSousFamille = refsousfamille;
            maFamille = famille;
            nomSousFamille = nomsousfamille;
        }

        public int RefSousFamille
        {
            get
            {
                return refSousFamille;
            }

            set
            {
                refSousFamille = value;
            }
        }

        internal Famille MaFamille
        {
            get
            {
                return maFamille;
            }

            set
            {
                maFamille = value;
            }
        }

        public string NomSousFamille
        {
            get
            {
                return nomSousFamille;
            }

            set
            {
                nomSousFamille = value;
            }
        }
    }
}
