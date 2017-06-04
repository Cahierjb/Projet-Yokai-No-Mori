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
        protected int[,] caseAccesible = new int[4, 3];
        private int compteur = 0;//ce champs est utilisé pour compter le nombre d'aller-retour d'une piece
        private bool aller = false;
        private bool retour = false;

        // Constructeur
        protected Pieces(int _posX, int _posY,int _numJ,string _img)
        {
            positionX = _posX;
            positionY = _posY;
            numJoueur = _numJ;
            image = _img;
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

        public virtual int[,] CaseAccessible(Plateau plat)//Méthode qui renvoie un tableau de même dimension que le terrain avec des 0 aux endroits où la piece ne peut pas aller et des 1 aux endroits où elle peut  
        {                                                 //Cette méthode est redéfinie pour chacune des classes filles de Pieces, car chaque piece possède des déplacements differents
            int[,] caseAccesible = new int[4, 3];
            return caseAccesible;
        }
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
        } //Méthode qui initialise le tableau CaseAccesible

        public void Deplacement(int posX, int posY, Plateau plat)//Méthode qui appelle la Méthode de plateau SetPosition pour la piece
        {
            plat.SetPosition(this, posX, posY);

        }

        public void Parachutage(int posX, int posY, Plateau plat)//Méthode de parachutage, cette méthode verifie que la piece destinée a être parachutée se trouve bien dans la reserve avant d'appeler la méthode SetPosition de plateau et de la supprimer de la reserve
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
        }//Cette méthode permet de compter le nombre d'aller-retour d'un Kodama

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