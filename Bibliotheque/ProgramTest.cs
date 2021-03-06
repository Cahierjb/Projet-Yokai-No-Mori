﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Bibliotheque
{
    class ProgramTest
    {
        static void Main(string[] args)
        {
            Plateau PlatTest = new Plateau();

            //Pieces joueurs 1
            Tanuki tanuj1 = new Tanuki(3, 2, 1,"");
            Koropokkuru koroj1 = new Koropokkuru(3, 1, 1,"");
            Kitsune kitsj1 = new Kitsune(3, 0, 1, "");
            Kodama kodj1 = PlatTest.PointerKod1;
            //Pieces joueur 2
            Tanuki tanuj2 = new Tanuki(0, 0, 2, "");
            Koropokkuru koroj2 = new Koropokkuru(0, 1, 2, "");
            Kitsune kitsj2 = new Kitsune(0, 2, 2, "");
            Kodama kodj2 = PlatTest.PointerKod2;
            Pieces piece;
            
  

            //PlatTest.initialisation(tanuj1,tanuj2,kitsj1,kitsj2,koroj1,koroj2,kodj1,kodj2);
            PlatTest.AfficheTestPlateau();
            PlatTest.AfficheReserve();

            Console.WriteLine();

           

            kodj2.Deplacement(3, 0, PlatTest);
            PlatTest.AfficheTestPlateau();
            PlatTest.AfficheReserve();

            piece = PlatTest.PointerKod1;

            piece.Deplacement(1, 1, PlatTest);
            PlatTest.AfficheTestPlateau();
            PlatTest.AfficheReserve();





            int[,] caseAccesible = new int[4, 3];
            caseAccesible = piece.CaseAccessible(PlatTest);
            Console.WriteLine("");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(caseAccesible[i, j]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
