namespace EcoleTLN
{
    public abstract class Employe : Personne
    {
        public string Laboratoire { get; set; }
        public int Salaire { get; set; }


        /// <summary>
        /// Constructeur d'Employe
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="annee"></param>
        /// <param name="labo"></param>
        /// <param name="salaire"></param>
        public Employe(string nom, int annee, string labo, int salaire): base(nom, annee)
        {
            this.Laboratoire = labo;
            this.Salaire = salaire;
        }


        public override string ToString()
        {
            return base.ToString() + "\tLaboratoire : " + this.Laboratoire + "\n\tSalaire : " + this.Salaire;
        }
    }
}
