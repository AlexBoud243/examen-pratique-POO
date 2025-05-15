using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public enum NiveauDifficulte
{
    facile,
    moyen,
    difficile,
}
namespace examen_pratique_poo
{
    public class PieceDeMusique
    {
        string[] noms = { "U2", "ACDC", "ED sheran", "bruno mars", "LAdy gaga", "jason derulo", "david simard", "les deux freres", "les trois accord" };
        public string Nom { get; set; }
        int[] quantite = { 200, 100, 150 };
        int QuantiteExp { get; set; }
        int[] prix = { 100, 111, 200, 300, 400, 120, 340 };
        public int Prix { get; set; }
        NiveauDifficulte NiveauDifficulte { get; set; }

        Random random = new Random();

        public PieceDeMusique(NiveauDifficulte niveauDifficulte)
        {
            NiveauDifficulte = niveauDifficulte;
            Nom = noms[random.Next(0, noms.Length)];
            InitialiseValeur();
        }

        public PieceDeMusique()
        {
            NiveauDifficulte = (NiveauDifficulte)random.Next(0,3) ;
            Nom = noms[random.Next(0, noms.Length)];
            InitialiseValeur();
        }

        public void InitialiseValeur()
        {
            switch (NiveauDifficulte)
            {
                case NiveauDifficulte.facile:
                    QuantiteExp += random.Next(10, 31); Prix += 200;
                    break;
                case NiveauDifficulte.moyen:
                    QuantiteExp += random.Next(60, 81); Prix += 400;
                    break;
                case NiveauDifficulte.difficile:
                    QuantiteExp += random.Next(100, 151); Prix += 600;
                    break;
            }
        }

        public override string ToString()
        {
            //TrouverNiveau();
            //RecompenseMusicien();
            string infoPiece = string.Empty;
            infoPiece += $"La piece {Nom} ,  possede une quantité d'experience de {QuantiteExp} et  coute {Prix} $";
            return infoPiece;

        }
    }
}
