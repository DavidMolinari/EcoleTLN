namespace EcoleTLN
{
    class EtudiantReguliuer : Etudiant
    {
        public EtudiantReguliuer(string section, double moyenne, string nom, int annee):base(moyenne, section, nom, annee)
        {
        }
    }
 
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
