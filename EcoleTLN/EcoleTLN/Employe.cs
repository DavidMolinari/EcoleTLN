namespace EcoleTLN
{
    public abstract class Employe : Personne
    {
        public string Laboratoire { get; set; }
        public int Salaire { get; set; }

        public Employe(string nom, int annee, string labo, int salaire): base(nom, annee)
        {
            this.Laboratoire = labo;
            this.Salaire = salaire;
        }

        public override string ToString()
        {
            return base.ToString() + "    Laboratoire : " + this.Laboratoire + "\n    Salaire : " + this.Salaire;
        }
    }
}
