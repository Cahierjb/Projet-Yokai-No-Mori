using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotheque
{
    public class Pieces
    {
        // Champs
        private int positionX;
        private int positionY;
        private int numJoueur;
        protected Plateau plat;
 
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
                if((value>=0) && (value <= 3))
                {
                    positionX = value;
                }
            }
        }
        public int PositionY
        {
            get { return positionX; }
            set
            {
                if ((value >= 0) && (value <= 2))
                {
                    positionX = value;
                }
            }
        }
        public int NumJoueur { get { return numJoueur; } }


        // Méthode

    }
}