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
            return "\tNom : " + this.Nom + "\n\tannee : " + this.Annee + '\n'; 
        }

        /// <summary>
        /// Constructeur de notre classe Mere, Personnen
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="annee"></param>
        public Personne(string nom, int annee)
        {
            this.Nom = nom;
            this.Annee = annee;
        }
    }

}
