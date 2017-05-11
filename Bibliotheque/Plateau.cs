using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotheque
{
    public class Plateau
    {
        //champs
        private Pieces[,] terrain = new Pieces[4,3];

        //Propriétés
        public Pieces this[int posX,int posY]
        {
            get { return terrain[posX,posY]; }
            set { terrain[posX,posY] = value;}
        }

        //Constructeurs
        public Plateau(Pieces[,] terr)
        {
            terrain = terr;
        }

        //Methodes
        public Pieces[,] initialisation()
        {
            Kitsune kitsj1 = new Kitsune(2,3);
            Kodama  kodj1 = new Kodama();
            Koropokkuru koroj1= new Koropokkuru();
            Tanuki tanuj1 = new Tanuki();
            Kitsune kitsj2 = new Kitsune(0,2);
            Kodama kodj2 = new Kodama();
            Koropokkuru koroj2 = new Koropokkuru();
            Tanuki tanuj2 = new Tanuki();
            terrain[0,0] = tanuj2;
            terrain[0,1] = koroj2;
            terrain[0,2] = kitsj2;
            terrain[1,1] = kodj2;
            terrain[3,0] = tanuj1;
            terrain[3,1] = koroj1;
            terrain[3,2] = kitsj1;
            terrain[2,1] = kodj1;
            return terrain;
        }
        public int[] GetPosition(Pieces piece)
        {
            int[] TabPosition = new int[2];
            for(int i = 0;i <= 3; i++)
            {
                for(int j = 0; j <= 2; i++)
                {
                    if (terrain[i,j] == piece)
                    {
                        TabPosition[0] = piece.PositionX;
                        TabPosition[1] = piece.PositionY;
                    }
                }
            }
            return TabPosition;
        }
      /*  public int[,] GetCaseAccesible(Pieces piece)
        {
            int[,] CaseAccesible = new int[3,4];
            if (piece.GetType() == typeof(Kitsune))
            {
                if (terrain[piece.PositionX + 1, piece.PositionY + 1] != null)
                {
                    CaseAccesible[piece.PositionX + 1, piece.PositionY + 1] = 1;
                }
                if (terrain[piece.PositionX + 1, piece.PositionY - 1] != null)
                {
                    CaseAccesible[piece.PositionX + 1, piece.PositionY - 1] = 1;
                }
                if (terrain[piece.PositionX - 1, piece.PositionY + 1] != null)
                {
                    CaseAccesible[piece.PositionX - 1, piece.PositionY + 1] = 1;
                }
                if (terrain[piece.PositionX - 1, piece.PositionY - 1] != null)
                {
                    CaseAccesible[piece.PositionX - 1, piece.PositionY - 1] = 1;
                }
            }
            else if (piece.GetType() == typeof(Tanuki))
            {

            }
            return CaseAccesible;
        }*/


    }
}