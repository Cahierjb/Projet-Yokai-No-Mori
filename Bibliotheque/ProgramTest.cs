using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    class ProgramTest
    {
        static void Main(string[] args)
        {
        //Pieces joueurs 1
        Tanuki tanuj1 = new Tanuki(3, 0, 1);
        Koropokkuru koroj1 = new Koropokkuru(3, 1, 1);
        Kitsune kitsj1 = new Kitsune(3, 2, 1);
        Kodama kodj1 = new Kodama(2, 1, 1);
        //Pieces joueur 2
        Tanuki tanuj2 = new Tanuki(0, 0, 2);
        Koropokkuru koroj2 = new Koropokkuru(0, 1, 2);
        Kitsune kitsj2 = new Kitsune(0, 2, 2);
        Kodama kodj2 = new Kodama(1, 1, 2);
        Kodama_Samurai koSj1;
        Kodama_Samurai koSj2;

            Plateau PlatTest = new Plateau();

        int[,] tabtest = new int[4,3];//tableau de test pour methode case accesible
        int[] tabtest2 = new int[2];//Tableau de test pour mehode GetPosition

        PlatTest.initialisation(tanuj1,tanuj2,kitsj1,kitsj2,koroj1,koroj2,kodj1,kodj2);
        PlatTest.AfficheTestPlateau();
        PlatTest.AfficheReserve();
        Console.WriteLine();
            /*tabtest = kitsj1.CaseAccesible(PlatTest);
            for (int x = 0; x <= 3; x++)
            {
                Console.WriteLine("");
                for (int y = 0; y <= 2; y++)
                {
                    Console.Write(tabtest[x, y]);
                }
             }
             Console.WriteLine("");
             tabtest2 = PlatTest.GetPosition(kitsj1);
             Console.Write("Getposition( x y ) : ( ");
             for (int i = 0; i <= 1; i++) Console.Write(tabtest2[i]+" ");
             Console.Write(")");*/
            kitsj1.Deplacement(1, 1, PlatTest);
            PlatTest.AfficheTestPlateau();
            PlatTest.AfficheReserve();
            PlatTest.Parachutage(kodj2, 3, 2);
            PlatTest.AfficheTestPlateau();
            PlatTest.AfficheReserve();
            kodj2.Deplacement(0, 2,PlatTest);
            PlatTest.AfficheTestPlateau();
            PlatTest.AfficheReserve();

            Console.ReadLine();

        }
    }
}
