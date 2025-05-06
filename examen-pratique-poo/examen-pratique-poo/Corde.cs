using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_pratique_poo
{
    internal class Corde
    {
        Random Rand = new Random();
        public int Resistance {  get; set; } 
        public int Durabilite { get; set; }
        public int NbUtilisation { get; set; }

        public Corde(int resistance,int durabilite,int nbUtilisation)
        {
            this.Resistance = resistance;
            this.Durabilite = durabilite;
            this.NbUtilisation = nbUtilisation;
        }

        public Corde()
        {
            this.Resistance = Rand.Next(1,11);
            this.Durabilite = Resistance;
            this.NbUtilisation = 10;
        }

        public int TrouverDurabilite()
        {
            Durabilite = Resistance * 2;

            return Durabilite;
        }

        public int ResistanceCorde()
        {
            if(NbUtilisation == 1)
            {
                Resistance--;
            }

            return Resistance;
        }

        public override string ToString()
        {
            ResistanceCorde();
            string infoCordes = string.Empty;
            TrouverDurabilite();
            infoCordes += $"la corde a une durabilité  de {Durabilite} et la résistance est de  {Resistance} et a été utilisé {NbUtilisation} fois";
            return infoCordes;
        }

        public static bool operator >(Corde c1, Corde c2)
        {
            return c1.Resistance > c2.Resistance;
        }

        public static bool operator <(Corde c1, Corde c2)
        {
            return c1.Resistance < c2.Resistance;
        }


    }
}
