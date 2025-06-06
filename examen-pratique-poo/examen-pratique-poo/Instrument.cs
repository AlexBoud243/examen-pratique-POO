﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum TypeViolon
{
    Guarneri,
    Stradivarius,
    Amati,
    Giuseppe,
}

public enum TypeG
{
    Acoustique,
    Basse,
    Electrique,
}

namespace examen_pratique_poo
{
    public  class Instrument
    {
        public string Nom {  get; set; }
        int PrixDachat {  get; set; }
        Corde corde;
        int NbCordes { get; set; }


        public Instrument(string nom, int nbCordes)
        {
            this.Nom = nom;
            corde = new Corde();
            PrixDachat = corde.Resistance * 200;
            this.NbCordes = nbCordes;
           
        }

        public Corde ResistanceCorde( Corde c1, Corde c2 )
        {
            Corde corde = null;

            if(c1 > c2)
            {
                corde = c1;
            }
            else
            {
                corde = c2;
            }

            return corde;
        }

        public void Reparer()
        {
            corde.Reparer();
        }

 
        public int TrouverPrixAchat()
        {
            PrixDachat = corde.Resistance * 200;

            return PrixDachat;
        }

        public override string ToString()
        {
            string infoInstrument = string.Empty;
            infoInstrument += $"L'instrument {Nom} a un prix d'achat de {PrixDachat} $ et a {NbCordes} cordes ";
            return infoInstrument;  
        }


        public static bool operator >(Instrument instrument1, Instrument instrument2)
        {
            return instrument1.corde.Resistance > instrument2.corde.Resistance;
        }

        public static bool operator <(Instrument instrument1, Instrument instrument2)
        {
            return instrument1.corde.Resistance < instrument2.corde.Resistance;
        }

    }
}
