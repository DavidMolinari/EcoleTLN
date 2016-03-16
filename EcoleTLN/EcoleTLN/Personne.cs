using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleTLN
{
    public abstract class Personne
    {
        public string Nom { get; set; }
        public int Annee { get; set; }
        public string Laboratoire { get; set; }
        public int Salaire { get; set; }
        public string SectionEnseignement { get; set; }

        /// <summary>
        /// Affiche les informations de la class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return " Nom : " + this.Nom + " annee : " + this.Annee; 
        }

        public Personne(string nom, int annee)
        {
            this.Nom = nom;
            this.Annee = annee;
        }
    }

}
