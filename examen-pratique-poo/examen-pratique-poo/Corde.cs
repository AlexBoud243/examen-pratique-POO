using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_pratique_poo
{
    public class Corde
    {
        public int Resistance { get; set; }
        public int Durabilite { get; set; }

        public Corde()
        {
            this.Resistance = Program.rand.Next(1, 11);
            this.Durabilite = Resistance * 2;

        }
        public override string ToString()
        {

            string infoCordes = string.Empty;
            infoCordes += $"la corde a une durabilité  de {Durabilite} et la résistance est de  {Resistance}";
            return infoCordes;
        }

        public void Reparer()
        {
            Durabilite = Resistance * 2;
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
