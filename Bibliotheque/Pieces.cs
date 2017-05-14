using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotheque
{
    public class Pieces
    {
        // Champs
        protected int positionX;
        protected int positionY;
        private int numJoueur;
        protected int[,] caseAccesible = new int[3, 2];

        // Constructeur
        public Pieces(int _posX, int _posY,int _numJ)
        {
            positionX = _posX;
            positionY = _posY;
            numJoueur = _numJ;
        }

        // Propriétés
        public int PositionX
        {
            get{return positionX;}
            set
            {
                if((value >= 0) && (value < 4))
                {
                    positionX = value;
                }
            }
        }
        public int PositionY
        {
            get { return positionY; }
            set
            {
                if ((value >= 0) && (value < 3))
                {
                    positionY = value;
                }
            }
        }
        public int NumJoueur { get { return numJoueur; } }


        // Méthode
        public void AfficheTestPiece()
        {
            Console.Write("( " + this.PositionX + " , " + this.PositionY + " )");
        }
    }
}