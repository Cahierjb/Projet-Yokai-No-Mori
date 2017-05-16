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
        public int NumJoueur
        {
            get { return numJoueur; }
            set { if (value > 0 && value < 3) numJoueur = value; }
        }
        // Méthode
        public void Deplacement(int posX, int posY, Plateau plat)
        {
            plat.SetPosition(this, posX, posY);

        }
        //fonction en vb qui presente le tableau case accesible et qui renvoie les coordonées de la case choisie 
        #region Methode de Test
        public void AfficheTestPiece()
        {
            if (this.GetType() == typeof(Kitsune)) {  Console.Write("Kits :"); }//determine la piece en question
            if (this.GetType() == typeof(Tanuki)) { Console.Write("Tanu :"); }//afin de connaitre quel piece placer en reserve
            if (this.GetType() == typeof(Kodama)) { Console.Write("Koda :"); }
            if (this.GetType() == typeof(Kodama_Samurai)) { Console.Write("KodS :"); }
            if (this.GetType() == typeof(Koropokkuru)) { Console.Write("Koro :"); }
            Console.Write("( " + this.PositionX + " , " + this.PositionY + " ) J"+this.numJoueur+"|");
        }
        #endregion

    }
}