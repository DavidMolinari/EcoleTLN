using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleTLN
{
    class EtudiantReguliuer : Etudiant
    {
        public EtudiantReguliuer(string section, double moyenne, string nom, int annee):base(moyenne, section, nom, annee)
        {
        }
    }
 
}
