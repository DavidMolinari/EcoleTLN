using System;
using System.Collections.Generic;

namespace EcoleTLN
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bind pour Console.WriteLine parce que je suis fénant
           
            Action<object> cw = Console.WriteLine;
            cw("Print Something");




            /// Liste de Test
            List<EtudiantEchange> etudiantsEchanges = new List<EtudiantEchange>();
            etudiantsEchanges.Add(new EtudiantEchange("MEHAYO", "SSC", 19.87, "Jean Bernard", 2000));
            etudiantsEchanges.Add(new EtudiantEchange("BRA", "SSC", 19.87, "Jean Norbert", 2000));

            etudiantsEchanges.Add(new EtudiantEchange("BRO", "SSC", 19.87, "Jean Phillipe", 2000));

            etudiantsEchanges.Add(new EtudiantEchange("BRI", "SSC", 19.87, "Jean Mahmah", 2000));

            etudiantsEchanges.Add(new EtudiantEchange("MEHAYO", "SSC", 19.87, "Jean meh", 2000));



            foreach (var meh in etudiantsEchanges)
            {
                cw(meh.ToString());
            }

            Console.Read();
        }
    }
}
