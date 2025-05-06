using System;
using System.Collections.Generic;
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
    internal class Instrument
    {
        public string Nom {  get; set; }
        int PrixDachat {  get; set; }
        Corde corde;
        int NbCordes { get; set; }


        public Instrument(string nom, int nbCordes)
        {
            this.Nom = nom;
            corde = new Corde();
            this.PrixDachat = corde.Resistance * 200;
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

    }
}
