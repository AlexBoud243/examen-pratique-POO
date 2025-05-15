using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_pratique_poo
{
    public class Musicien
    {
        string Nom {  get; set; }
        public Instrument Instrument {  get; set; } 
        public int Niveau { get; set; } = 1;
        public int MontantArgent {  get; set; }
        int Experience { get; set; }
        public List<PieceDeMusique> pieceDeMusiques { get; set; }

        public Musicien(string nom, Instrument instrumentPrefere, int niveau, int montantArgent)
        {
            Nom = nom;
            Instrument = instrumentPrefere;
            Niveau = niveau;
            MontantArgent = montantArgent;
            this.pieceDeMusiques = pieceDeMusiques;
            pieceDeMusiques = new List<PieceDeMusique>();
            pieceDeMusiques.Add(new PieceDeMusique(NiveauDifficulte.facile));
        }

        public string InfoPieces()
        {
            int i = 1;
            string info = string.Empty;

            foreach(PieceDeMusique pieceDeMusique in pieceDeMusiques)
            {

                info += i + " - " + pieceDeMusique;
                i++;
            }
            return info;
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
            InfoPieces();
            infoMusicien += $" Le musicien {Nom} \n Adore l'instrument{Instrument
                }  \n Il possede un nivau d'expertise de {Niveau} \n Une fortne de {MontantArgent} $ \n et une experinece de {Experience} \n";
            return infoMusicien;
        }
    }
}
