using System;
using System.Windows;



namespace EcoleTLN
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bind pour Console.WriteLine parce que je suis fénant
            Action<object> cw = Console.WriteLine;
            Ecole uneEcole = new Ecole();



            /// Liste d'étudiant et personnel à Ajouter.
            uneEcole.Ajouter(new EtudiantRegulier(6.0, "SSC", "Gaston Peutimide", 2013));
            uneEcole.Ajouter(new EtudiantRegulier(2.5, "SSC", "Yvan Rattrapeur", 2011));
            uneEcole.Ajouter(new EtudiantEchange("KTH", "Informatique", "Bjorn Borgue", 2012));
            uneEcole.Ajouter(new Enseignant("Mathieu Matheu", 1998, "LMEP", 10000, "Physique"));
            uneEcole.Ajouter(new Secretaire("Sophie Scibona", 2005, "LMT", 5000));


            /// Appelle de le maéthode AfficheListeDesPersonnes.
            uneEcole.AfficheListeDesPersonnes();

            
            Console.Read();
        }
    }
}
