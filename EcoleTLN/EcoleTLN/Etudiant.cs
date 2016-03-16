namespace EcoleTLN
{
    public abstract class Etudiant : Personne
    {
        public string Section { get; set; }
        public double Moyenne { get; set; }

        public Etudiant(double moyenne, string section, string nom, int annee) : base(nom, annee)
        {
            this.Section = section;
            this.Moyenne = moyenne;
        }

        /// <summary>
        /// Affiche les informations de la class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + "    Section : " + this.Section + "\n    Moyenne : " + this.Moyenne;
        }
    }


}
