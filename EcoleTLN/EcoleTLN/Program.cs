﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleTLN
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EtudiantEchange> etudiantsEchanges = new List<EtudiantEchange>();
            etudiantsEchanges.Add(new EtudiantEchange("MEHAYO", "SSC", 19.87, "Jean Bernard", 2000));
            etudiantsEchanges.Add(new EtudiantEchange("BRA", "SSC", 19.87, "Jean Norbert", 2000));

            etudiantsEchanges.Add(new EtudiantEchange("BRO", "SSC", 19.87, "Jean Phillipe", 2000));

            etudiantsEchanges.Add(new EtudiantEchange("BRI", "SSC", 19.87, "Jean Mahmah", 2000));

            etudiantsEchanges.Add(new EtudiantEchange("MEHAYO", "SSC", 19.87, "Jean meh", 2000));



            foreach (var meh in etudiantsEchanges)
            {
                Console.WriteLine(meh.ToString());
            }

            Console.Read();
        }
    }
}
