using System;

namespace EcoleTLN
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bind pour Console.WriteLine parce que je suis fénant
           
            Action<object> cw = Console.WriteLine;
            Ecole uneEcole = new Ecole();
            cw("Print Something");




            // Liste de Test
            uneEcole.Ajouter(new EtudiantRegulier(6.0, "SSC", "Gaston Peutimide", 2013));


            uneEcole.AfficheListeDesPersonnes();


            Console.Read();
        }
    }
}
