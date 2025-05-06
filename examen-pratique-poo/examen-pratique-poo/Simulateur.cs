using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_pratique_poo
{
    internal class Simulateur
    {
        public Simulateur()
        {
            int choix = 0;
            Instrument instrument = new Instrument("guitare", 200, 6);
            Corde corde1 = new Corde(50, 100, 0);
            Musicien musicien = new Musicien("Alex",instrument,1,1000);
            PieceDeMusique pieceDeMusique = new PieceDeMusique("les trois accords",Random.next())



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
                switch (choix)
                {
                    case 1:
                        Console.WriteLine("Voici l'info de mon musicien ... \n");
                        Console.WriteLine(musicien);
                        Console.WriteLine(instrument);
                        Console.WriteLine(corde1);
                        break;
                    case 2:
                        //jaurais fai un do while tant que le coix nest pas 4 il ne choisi de piece , sinon si il choisi une piece , l'experience sera ajouter selon la diffiuclté de la piece avce ma fonction dans la classes 

                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                }


            }
            while (choix != 3);
        }
    }
}
