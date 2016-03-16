using System;
using System.Collections.Generic;

namespace EcoleTLN
{
    class Ecole
    {
        Action<object> cw = Console.WriteLine;


        private int nbEtudiant { get; }
        private List<Personne> listPersonnes = new List<Personne>();

        public void AfficheListeDesPersonnes()
        {
            foreach (var i in listPersonnes)
            {
                Console.WriteLine(i.ToString());
            }

        }

        public void Ajouter (Personne unePersonne)
        {
            listPersonnes.Add(unePersonne);
        }

    }
}
