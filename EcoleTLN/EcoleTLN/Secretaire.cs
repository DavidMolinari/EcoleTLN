﻿namespace EcoleTLN
{
    class Secretaire : Employe
    {
        public Secretaire (string nom, int annee, string labo, int salaire) : base (nom, annee, labo, salaire)
        {
            // Oui je suis vide, huehuehuehue.
        }

        public override string ToString()
        {
            return "Secrétaire : \n" + base.ToString();
        }

    }
}
