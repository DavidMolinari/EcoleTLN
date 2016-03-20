namespace EcoleTLN
{
    class Enseignant : Employe
    {

        string SectionEnseignement { get; set; }


        /// <summary>
        /// Constructeur Enseignant
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="annee"></param>
        /// <param name="labo"></param>
        /// <param name="salaire"></param>
        /// <param name="sec"></param>
        public Enseignant(string nom, int annee, string labo, int salaire, string sec):base(nom, annee, labo, salaire)
        {
            this.SectionEnseignement = sec;
        }


        public override string ToString()
        {
            return "Enseignant : \n" + base.ToString() + "\n\tSection : " + this.SectionEnseignement;
        }

    }
}
