namespace EcoleTLN
{
    public abstract class Etudiant : Personne
    {
        public string Section { get; set; }
        

        /// <summary>
        /// Constructeur Etudiant herite du constructeur Personne
        /// </summary>
        /// <param name="section"></param>
        /// <param name="nom"></param>
        /// <param name="annee"></param>
        public Etudiant(string section, string nom, int annee) : base(nom, annee)
        {
            this.Section = section;
        }

        /// <summary>
        /// Affiche les informations de la class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + "\tSection : " + this.Section;
        }
    }


}
