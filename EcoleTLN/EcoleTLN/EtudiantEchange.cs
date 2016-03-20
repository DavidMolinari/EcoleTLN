namespace EcoleTLN
{
    class EtudiantEchange : Etudiant
    {
        public string UniOrigine { get; set; }

        public double Moyenne { get; set; }

        /// <summary>
        /// Constructeur EtudiantEchange qui hérite du constructeur d'un Etudiant
        /// </summary>
        /// <param name="uniOrigine"></param>
        /// <param name="section"></param>
        /// <param name="nom"></param>
        /// <param name="annee"></param>
        public EtudiantEchange(string uniOrigine, string section, string nom, int annee):base(section, nom, annee)
        {
            this.UniOrigine = uniOrigine;
        }

        /// <summary>
        /// Affiche les informations de la class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Etudiant d'échange : \n" + base.ToString() + "\n\tUni : " + this.UniOrigine; 
        }
    }
}
