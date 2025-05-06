using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_pratique_poo
{
    internal class Musicien
    {
        string Nom {  get; set; }
        Instrument InstrumentPrefere {  get; set; } 
        public int Niveau { get; set; } = 1;
        int MontantArgent {  get; set; }
        int Experience { get; set; }

        public Musicien(string nom, Instrument instrumentPrefere, int niveau, int montantArgent)
        {
            Nom = nom;
            InstrumentPrefere = instrumentPrefere;
            Niveau = niveau;
            MontantArgent = montantArgent;
        }

        public int ChangerDeNiveau()
        {
            if (Niveau == Niveau && Experience == 100)
            {
                Niveau++;
                Experience =-100;


            }

            return Niveau;
        }

        public override string ToString()
        {
            string infoMusicien = string.Empty;
            ChangerDeNiveau();
            infoMusicien += $" Le musicien {Nom} \n Adore l'instrument{InstrumentPrefere}  \n Il possede un nivau d'expertise de {Niveau} \n Une fortne de {MontantArgent} $ \n et une experinece de {Experience} \n";
            return infoMusicien;
        }
    }
}
