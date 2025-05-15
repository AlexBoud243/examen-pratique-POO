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
            musicien = new Musicien("Alex", new Violon(), 1000);
        }

        void ChoisirMeilleurInstrument()
        {
            int nbInstrumentGenerer = 5;
            //Generer 5 instruments 
            List<Instrument> instruments = new List<Instrument>();

            for (int i = 0; i < nbInstrumentGenerer; i++)
            {
                int choixRandom = Program.rand.Next(2);
                if (choixRandom == 0)
                    instruments.Add(new Guitare("", 6));
                else
                    instruments.Add(new Violon());
            }

            //Afficher les 5


            //Choisir le meilleur
            Instrument leMeilleur = instruments[0];
            for (int i = 1; i < instruments.Count; i++)
            {
                if (instruments[i] > leMeilleur)
                    leMeilleur = instruments[i];
            }

            //affiche le meilleur
            musicien.Instrument = leMeilleur;
        }
        public void LancerSimulation()
        {
            ChoisirMeilleurInstrument();
  
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
                    case 1: Console.WriteLine(musicien); break;
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

                        //version 2
                        /*List<PieceMusique> pieces = new List<PieceMusique>();

                        //Créer les 3 pièces
                        for (int i = 0; i < nbPieceDispo; i++)
                            pieces.Add(new PieceMusique());

                        //Afficher les 3 pièce
                        for (int i = 0; i < nbPieceDispo; i++)
                            Console.WriteLine($"{i} - {pieces[i]} ");

                        int choix2 = Convert.ToInt32(Console.ReadLine());

                        if (pieces[choix2].Prix <= musicienPro.Montant)
                        {
                            musicienPro.Montant -= pieces[choix2].Prix;
                            musicienPro.AjouterChanson(pieces[choix2]);
                            Console.WriteLine($"Cool tu a acheté la chanson :{pieces[choix2].Nom}\n");
                        }
                        else
                            Console.WriteLine("Pas asser d'argent ,va faire un show!!\n");
                        */

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
            while (choix != 6);

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
