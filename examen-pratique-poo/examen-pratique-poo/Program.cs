/**********************************************/
/*  Nom :   Alex Boudreault
    Date :  2025-05-02
    Description : examen pratique de pratique


    Probleme rencontre :  les classes etait dificile a complété

    IMPORTANT - SI CETTE PARTIE N'EST PAS REMPLIE
    IL N'Y AURA PAS DE CORRECTION ( DONC 0 ) =)


    TODO : 
    - Terminer le simulateur ( faire les fonctionnalités plus facile, exemple : réparer )
    - Changer de niveau, à revoir avec Vincent
    - Piece à compléter
*/
/**********************************************/
namespace examen_pratique_poo
{
    internal class Program
    {
        public static Random rand = new Random();
        static void Main(string[] args)
        {
            Simulateur simulateur = new Simulateur();
            simulateur.LancerSimulation();
        }
    }
}
