using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_pratique_poo
{
    internal class Guitare : Instrument
    {
        public Guitare(string nom, int nbCordes) : base(nom,nbCordes)
        {
            Nom = TrouverNomGuitare(TypeG.Acoustique);
        }

        public string TrouverNomGuitare(TypeG typeG)
        {
            string Nom = "Guitare";
            if (typeG == TypeG.Acoustique)
            {
                Nom += " Acoustique";
            }
            else if (typeG == TypeG.Basse)
            {
                Nom += " Basse";
            }
            else
            {
                Nom += " Electrique";
            }


            return Nom;
        }

    }
}
