namespace EcoleTLN
{
    public class EtudiantRegulier : Etudiant
    {
        private double moyenne;

        /// <summary>
        /// Constructeur d'un EtudiantRegulier qui hérite du constructeur d'un Etudiant.
        /// </summary>
        /// <param name="moyenne"></param>
        /// <param name="section"></param>
        /// <param name="nom"></param>
        /// <param name="annee"></param>
        public EtudiantRegulier(double moyenne, string section, string nom, int annee):base(section, nom, annee)
        {
            this.moyenne = moyenne;
        }

        public override string ToString()
        {
            return "Etudiant régulier : \n" + base.ToString() + "\n\tMoyenne : " + this.moyenne;
        }

    }
}
