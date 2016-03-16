namespace EcoleTLN
{
    class EtudiantEchange : Etudiant
    {
        public string UniOrigine { get; set; }


        public EtudiantEchange(string uniOrigine, string section, double moyenne, string nom, int annee):base(moyenne, section, nom, annee)
        {
            this.UniOrigine = uniOrigine;
        }

        /// <summary>
        /// Affiche les informations de la class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + " Uni : " + this.UniOrigine; 
        }
    }
}
