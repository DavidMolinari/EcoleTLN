namespace EcoleTLN
{
    public class EtudiantRegulier : Etudiant
    {
        private double moyenne;

        public EtudiantRegulier(double moyenne, string section, string nom, int annee):base(section, nom, annee)
        {
            this.moyenne = moyenne;
        }

        public override string ToString()
        {
            return "Etudiant régulier : \n" + base.ToString() + "\n     Moyenne : " + this.moyenne;
        }

    }
}
