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
            return "Enseignant : \n" + base.ToString() + "\n    Section : " + this.SectionEnseignement;
        }

    }
}
