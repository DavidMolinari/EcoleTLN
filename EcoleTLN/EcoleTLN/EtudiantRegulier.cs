using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleTLN
{
 
    public class EtudiantRegulier : Etudiant
    {


        public override string ToString()
        {
            return base.ToString();
        }

        public EtudiantRegulier(double moyenne, string section, string nom, int annee):base(moyenne, section, nom, annee)
        {

        }
    }
}
