using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace examen_pratique_poo
{
    public class Violon : Instrument
    {
        public Violon(string nom, int nbCordes) : base(nom,nbCordes)
        {

        }

        public Violon() : base("", 4)
        {
            Nom = TrouverNomViolon(TypeViolon.Giuseppe);
        }
        public string TrouverNomViolon(TypeViolon typeViolon)
        {
            string Nom = "Violon";
            if (typeViolon == TypeViolon.Guarneri)
            {
                Nom += " Guarneri";
            }
            else if(typeViolon == TypeViolon.Amati)
            {
                Nom += " Amati";
            }
            else  if(typeViolon == TypeViolon.Stradivarius)
            {
                Nom += " Stradivarius";
            }
            else
            {
                Nom += " Giuseppe";
            }

            return Nom;
        }
    }
}
