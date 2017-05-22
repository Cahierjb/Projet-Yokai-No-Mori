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
            Tanuki tanuj1 = new Tanuki(3, 2, 1);
            Koropokkuru koroj1 = new Koropokkuru(3, 1, 1);
            Kitsune kitsj1 = new Kitsune(3, 0, 1);
            Kodama kodj1 = new Kodama(2, 1, 1);
            //Pieces joueur 2
            Tanuki tanuj2 = new Tanuki(0, 0, 2);
            Koropokkuru koroj2 = new Koropokkuru(0, 1, 2);
            Kitsune kitsj2 = new Kitsune(0, 2, 2);
            Kodama kodj2 = new Kodama(1, 1, 2);

            Pieces piece;
            
            Plateau PlatTest = new Plateau();

            

            int[,] tabtest = new int[4,3];//tableau de test pour methode case accesible
            int[] tabtest2 = new int[2];//Tableau de test pour mehode GetPosition

            PlatTest.initialisation(tanuj1,tanuj2,kitsj1,kitsj2,koroj1,koroj2,kodj1,kodj2);
            PlatTest.AfficheTestPlateau();
            PlatTest.AfficheReserve();

            Console.WriteLine();

            piece = kitsj1;
            piece.Deplacement(1, 1, PlatTest);
            PlatTest.AfficheTestPlateau();
            PlatTest.AfficheReserve();

            piece = kodj2;
            PlatTest.Parachutage(piece, 3, 0);
            PlatTest.AfficheTestPlateau();
            PlatTest.AfficheReserve();

            piece.Deplacement(0, 0,PlatTest);
            Console.WriteLine(piece.GetType());
            PlatTest.AfficheTestPlateau();
            PlatTest.AfficheReserve();

            piece.Deplacement(1, 0, PlatTest);
            PlatTest.AfficheTestPlateau();
            PlatTest.AfficheReserve();

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
