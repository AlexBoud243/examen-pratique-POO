using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_pratique_poo
{
    internal class Simulateur
    {
        Musicien musicien;
        
        public Simulateur()
        {
            musicien = new Musicien("Alex", new Violon(), 1, 1000);
        }

        public void LancerSimulation()
        {
            int choix = 0;
            int choixPiece = 0;
            do
            {
                Console.WriteLine("********** BIENVENUE DANS LE MENU  **********");

                Console.WriteLine("Quel voulez-vous faire ?");
                Console.WriteLine("1 : Voir le statut du musicien / Instruments");
                Console.WriteLine("2 : Pratiquer ");
                Console.WriteLine("3 : Réparer son instrument");
                Console.WriteLine("4 : Acheter une nouvelle pièce");
                Console.WriteLine("5 : Jouer pour un public ");
                Console.WriteLine("6 : Quitter");
                choix = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choix)
                {
                    case 1:
                        Console.WriteLine("Voici l'info de mon musicien ... \n");
                        Console.WriteLine(musicien);
                        break;
                    case 2:
                        Console.WriteLine("voici les pieces que vous possedez :");
                        Console.WriteLine(musicien.InfoPieces());
                        Console.WriteLine("Laquel voulez-vous jouer ? ");
                        choix = Convert.ToInt32(Console.ReadLine());
                        if(choix == 1)
                        {

                        }

                        break;
                    case 3:
                        musicien.Instrument.Reparer();
                        Console.WriteLine("L'instrument a été réparé");
                        break;
                    case 4:
                        PieceDeMusique pieceDeMusique1 = new PieceDeMusique();
                        PieceDeMusique pieceDeMusique2 = new PieceDeMusique();
                        PieceDeMusique pieceDeMusique3 = new PieceDeMusique();
                        Console.WriteLine("Quelle piece voulez-vous acheter ?");
                        Console.WriteLine("1 :" + pieceDeMusique1);
                        Console.WriteLine("2 :" + pieceDeMusique2);
                        Console.WriteLine("3 :" + pieceDeMusique3);
                        choixPiece = Convert.ToInt32(Console.ReadLine());
                        if(choixPiece == 1)
                        {
                            AcheterPiece(pieceDeMusique1);
                            pieceDeMusique1.Prix =- musicien.MontantArgent;

                        }
                        else if(choixPiece == 2)
                        {
                            AcheterPiece(pieceDeMusique3);
                            pieceDeMusique2.Prix = -musicien.MontantArgent;
                        }
                        else if(choixPiece == 3)
                        {
                            AcheterPiece(pieceDeMusique3);
                            pieceDeMusique3.Prix = -musicien.MontantArgent;
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                }
            }
            while (choix != 3);



        }

        public void AcheterPiece(PieceDeMusique pieceDeMusique)
        {
            if(pieceDeMusique.Prix <= musicien.MontantArgent)
            {
                musicien.pieceDeMusiques.Add(pieceDeMusique);
                Console.WriteLine("la piece a bien été ajouté au cartable ...");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Fond inssufisant ...");
            }
        }
    }
}
