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
        protected string image;
        protected int[,] caseAccesible = new int[3, 2];

        private int compteur = 0;
        private bool aller = false;
        private bool retour = false;

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
        public string Image { get { return image; } }
        public int Compteur { get; set; }

        // Méthode
        public int[,] InitTableau()
        {
            int[,] caseAccesible = new int[4, 3];
            for (int i = 0; i == 3; i++)
            {
                for (int j = 0; j == 2; j++)
                {
                    caseAccesible[i, j] = 0;
                }
            }

            return caseAccesible;
        }

        public void Deplacement(int posX, int posY, Plateau plat)
        {
            plat.SetPosition(this, posX, posY);

        }

        public void Parachutage(int posX, int posY, Plateau plat)
        {
            for (int i = 0; i <= 2; i++)
            {
                if (this.NumJoueur == 2)
                {
                    if (this == plat.ReserveJ2[i])
                    {
                        plat.SetPosition(this, posX, posY);
                        plat.ReserveJ2[i] = null;
                    }
                }
                if (this.NumJoueur == 1)
                {
                    if (this == plat.ReserveJ1[i])
                    {
                        plat.SetPosition(this, posX, posY);
                        plat.ReserveJ1[i] = null;
                    }
                }

            }
        }

        public int Position()
        {

            if (this.NumJoueur == 1)
            {
                if (this.PositionX == 0)
                {
                    aller = true;
                }
                if (aller && this.PositionX == 3)
                {
                    retour = true;
                }
                if (aller && retour)
                {
                    compteur++;
                    aller = false;
                    retour = false;
                }
            }
            if (this.NumJoueur == 2)
            {
                if (this.PositionX == 3)
                {
                    aller = true;
                }
                if (aller && this.PositionX == 0)
                {
                    retour = true;
                }
                if (aller && retour)
                {
                    compteur++;
                    aller = false;
                    retour = false;
                }
            }
            return compteur;
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