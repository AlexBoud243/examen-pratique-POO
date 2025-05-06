using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum NiveauDifficulte
{
    facile,
    moyen,
    difficile,
}
namespace examen_pratique_poo
{
    internal class PieceDeMusique
    {
        string Nom {  get; set; } 
        int QuantiteExp{  get; set; }
        string Prix{  get; set; }
        Musicien Musicien { get; set; }
        Random Random;

        public PieceDeMusique(string nom, int quantiteExp, string prix, NiveauDifficulte niveauDifficulte)
        {
            Nom = nom;
            QuantiteExp = quantiteExp;
            Prix = prix;
        }

        

        public NiveauDifficulte TrouverNiveau()
        {
            if(Musicien.Niveau == 1)
            {
               return NiveauDifficulte.facile;
            }
            else if(Musicien.Niveau == 2 || Musicien.Niveau == 3)
            {
                return NiveauDifficulte.moyen;
            }
            else
            {
                return NiveauDifficulte.difficile;
            }
        }

        public void RecompenseMusicien()
        {
            NiveauDifficulte niveauDifficulte = TrouverNiveau();

            switch (niveauDifficulte)
            {
                case NiveauDifficulte.facile:
                    QuantiteExp += Random.Next(10, 31); Prix += 200;
                    break;
                case NiveauDifficulte.moyen:
                    QuantiteExp += Random.Next(60, 81); Prix += 400;
                    break;
                case NiveauDifficulte.difficile:
                    QuantiteExp += Random.Next(100, 151); Prix += 600;
                    break;
            }
        }

        public override string ToString()
        {
            TrouverNiveau();
            RecompenseMusicien();
            string infoPiece = string.Empty;
            infoPiece += $"La piece {Nom} ,  possede une quantité d'experience de {QuantiteExp}";
            return infoPiece;  

        }
    }
}
