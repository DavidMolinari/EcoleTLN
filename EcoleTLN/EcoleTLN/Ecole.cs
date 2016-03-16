using System;
using System.Collections.Generic;

namespace EcoleTLN
{
    class Ecole
    {
        Action<object> cw = Console.WriteLine;


        private int nbEtudiants;
        private List<Personne> listPersonnes = new List<Personne>();

        public void AfficheListeDesPersonnes()
        {
            foreach (var i in listPersonnes)
            {
                if (this.EstEtudiant(i))
                {
                    this.nbEtudiants += 1;
                }
            }

            cw("Parmi les " + listPersonnes.Count + " personnes de l'écoleTLN, " + this.nbEtudiants + " Sont des étudiants.");
            cw("Ils sont à l'école depuis en moyenne " + this.MoyenneAge(this.listPersonnes) + " ans");

            foreach (var i in listPersonnes)
            {
                cw(i.ToString());
            }

        }

        public void Ajouter (Personne unePersonne)
        {
            listPersonnes.Add(unePersonne);
        }

        /// <summary>
        /// Permet de savoir si la personne est étudiante ou non
        /// </summary>
        /// <param name="unePersonne">Personne à check</param>
        /// <returns>Etudiant ou non</returns>
        private bool EstEtudiant(Personne unePersonne)
        {
            if (unePersonne is Etudiant)
            {
                return true;
            } else
            {
                return false;
            }
        }

        private float MoyenneAge (List<Personne> listPersonnes)
        {
            DateTime moment = DateTime.Now;
            float result = 0;
            int nbrPers = listPersonnes.Count;

            foreach(var i in listPersonnes)
            {
                result += moment.Year - i.Annee;
            }


            return result / nbrPers;
        }
    }
}
