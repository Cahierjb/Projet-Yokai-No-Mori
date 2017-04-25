using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotheque
{
    public class Plateau
    {
        //champs
        private int[,] terrain= new int [3, 4];
        private int pieceJ1 = 1;
        private int pieceJ2 = 2;

        //Propriétés
        public int[,] Terrain
        {
            get
            {
                return terrain;
            }
        }

        //Constructeurs
        public Plateau(int[,] terr)
        {
            terrain = terr;
        }

        //Methodes
        public int[,] initialisation()
        {
            for(int i = 0; i <= 3; i++)
            {
                for(int j = 0; j <= 4; j++)
                {
                    terrain[i,j]=0;
                }
            }
            for(int i = 0;i <= 3; i++) { terrain[i, 1] = 2; }
            terrain[2,2] = 2;
            for (int i = 0; i <= 3; i++) { terrain[i, 3] = 2; }
            terrain[3,2] = 1;
            return terrain;
        }
    }
}