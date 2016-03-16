namespace EcoleTLN
{
    public abstract class Personne
    {
        public string Nom { get; set; }
        public int Annee { get; set; }


        /// <summary>
        /// Affiche les informations de la class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return " Nom : " + this.Nom + " annee : " + this.Annee + ' '; 
        }

        public Personne(string nom, int annee)
        {
            this.Nom = nom;
            this.Annee = annee;
        }
    }

}
