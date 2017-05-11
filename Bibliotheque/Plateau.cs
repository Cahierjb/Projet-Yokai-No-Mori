using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotheque
{
    public class Plateau
    {
        //champs
        private Pieces[,] terrain = new Pieces[4, 3];
        private Pieces[] ReserveJ1 = new Pieces[3];
        private Pieces[] ReserveJ2 = new Pieces[3];


        //Propriétés
        public Pieces[,] this[int posX,int PosY]
        {
              get { return terrain; }
          //  set { SetPosition(piece); }
        }


        //Constructeurs
        public Plateau(Pieces[,] terr,Pieces[] resJ1,Pieces[] resJ2)
        {
            terrain = terr;
            ReserveJ1 = resJ1;
            ReserveJ2 = resJ2;
        }

        //Methodes
        public Pieces[,] initialisation()
        {
            ReserveJ1 = null;
            ReserveJ2 = null;
            Kitsune kitsj1 = new Kitsune(2, 3, 1);
            Kodama kodj1 = new Kodama();
            Koropokkuru koroj1 = new Koropokkuru();
            Tanuki tanuj1 = new Tanuki();
            Kitsune kitsj2 = new Kitsune(0, 2, 2);
            Kodama kodj2 = new Kodama();
            Koropokkuru koroj2 = new Koropokkuru();
            Tanuki tanuj2 = new Tanuki();
            terrain[0, 0] = tanuj2;
            terrain[0, 1] = koroj2;
            terrain[0, 2] = kitsj2;
            terrain[1, 1] = kodj2;
            terrain[3, 0] = tanuj1;
            terrain[3, 1] = koroj1;
            terrain[3, 2] = kitsj1;
            terrain[2, 1] = kodj1;
            return terrain;
        }
        public int[] GetPosition(Pieces piece)
        {
            int[] TabPosition = new int[2];
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 2; i++)
                {
                    if (terrain[i, j] == piece)
                    {
                        TabPosition[0] = terrain[i,j].PositionX;
                        TabPosition[1] = terrain[i,j].PositionY;
                    }
                }
            }
            return TabPosition;
        }
        public void SetPosition(Pieces piece)
        {
            int[] pospiece = GetPosition(piece);
            int typepiece = 0;
            if ((pospiece[0] == 0) && (pospiece[1] == 0))
            {
                terrain[piece.PositionX, piece.PositionY] = piece;
            }
            if (piece.GetType() == typeof(Kitsune)) typepiece = 0;
            if (piece.GetType() == typeof(Tanuki)) typepiece = 1;
            if (piece.GetType() == typeof(Kodama)) typepiece = 2;
            else if (piece.NumJoueur == 1)
            {
                ReserveJ1[typepiece] = terrain[piece.PositionX, piece.PositionY];
            }
            else if (piece.NumJoueur == 2)
            {
                ReserveJ2[typepiece] = terrain[piece.PositionX, piece.PositionY];
            }
        }

        public bool CheckCase(int posX, int posY)
        {
            if (terrain[posX, posY] != null)
            {
                return true;
            }
            else return false;
        }



    }
}