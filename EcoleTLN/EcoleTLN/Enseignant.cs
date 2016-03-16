using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleTLN
{
    class Enseignant : Employe
    {

        string SectionEnseignement { get; set; }


        public Enseignant(string nom, int annee, string labo, int salaire, string sec):base(nom, annee, labo, salaire)
        {
            this.SectionEnseignement = sec;
        }


        public override string ToString()
        {
            return base.ToString() + " section : " + this.SectionEnseignement;
        }

    }
}
