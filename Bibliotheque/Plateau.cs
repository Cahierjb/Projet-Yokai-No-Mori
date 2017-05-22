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
        private Pieces[] reserveJ1 = new Pieces[3];
        private Pieces[] reserveJ2 = new Pieces[3];                                                                                                                                             
        private int findepartie = 0;

        //Constructeurs
        public Plateau() { }

        //Propriétées
        public Pieces[] ReserveJ1
        {
            get { return this.reserveJ1; }
            set { this.reserveJ1 = value; }
        }
        public Pieces[] ReserveJ2
        {
            get { return this.reserveJ2; }
            set { this.reserveJ2 = value; }
        }
        public int Findepartie { get;}

        //Methodes
        public Pieces[,] initialisation(Tanuki tanuj1,Tanuki tanuj2,Kitsune kitsj1,Kitsune kitsj2,Koropokkuru koroj1, Koropokkuru koroj2, Kodama kodj1,Kodama kodj2)//instancie les pieces et les place a leur position initiale, vide également les reserves des joueurs
        {
            for (int i = 0;i == 2 ; i++) ReserveJ1[i] = null;
            for (int i = 0; i == 2; i++) ReserveJ2[i] = null;
            for (int i = 0; i == 3; i++)
            {
                for (int j = 0; j == 2; j++)
                {
                    terrain[i, i] = null;
                }
            }
            //Pieces joueurs 1
            terrain[3, 2] = tanuj1;
            terrain[3, 1] = koroj1;
            terrain[3, 0] = kitsj1;
            terrain[2, 1] = kodj1;
            //Pieces joueur 2
            terrain[0, 0] = tanuj2;
            terrain[0, 1] = koroj2;
            terrain[0, 2] = kitsj2;
            terrain[1, 1] = kodj2;

            return terrain;
        }

        private int[] GetPosition(Pieces piece)//Permet de connaitre la position d'une piece sur le terrain de jeu
        {
            int[] TabPosition = new int[2];
            foreach(Pieces element in terrain)
            { 
                    if (element != null)
                    {
                        if (element == piece)//verifie si les pieces sont identiques
                        {
                            TabPosition[0] = element.PositionX;
                            TabPosition[1] = element.PositionY;
                            break;
                        }
                    }
            }
            return TabPosition;
        }

        public void SetPosition(Pieces piece, int newx, int newy)//Permet de changer la position d'une pieces
        {
            int typepiece = -1;
            int[] AncienePosition = new int[2];
            AncienePosition = GetPosition(piece);

            piece.PositionX = newx;
            piece.PositionY = newy;

            bool Deplacement = false;//drapeau faux tant que le deplacement de la piece na pas etait acceptée

            if (terrain[newx, newy] != null)
            {
                if (terrain[newx, newy].GetType() == typeof(Kitsune)) { typepiece = 0; }//determine la piece en question
                if (terrain[newx, newy].GetType() == typeof(Tanuki)) { typepiece = 1; }//afin de connaitre quel piece placer en reserve
                if (terrain[newx, newy].GetType() == typeof(Kodama)) { typepiece = 2; }
                if (terrain[newx, newy].GetType() == typeof(Koropokkuru)) { typepiece = 3; }
            }
            
            if (terrain[newx, newy] == null)// cas ou la case est vide
            {
                terrain[newx,newy] = piece;
                Deplacement = true;
            }
            else if (terrain[newx, newy].NumJoueur == 1)//cas ou la case appartient au joueur adverse si le joueur est le joueur 1
            {
                terrain[newx, newy].NumJoueur = 2;
                ReserveJ2[typepiece] = terrain[newx, newy];
                terrain[newx, newy] = piece;
                Deplacement = true;
            }
            else if (terrain[newx, newy].NumJoueur == 2)//cas ou la case appartient au joueur adverse si le joueur est le joueur 2
            {
                terrain[newx, newy].NumJoueur = 1;
                ReserveJ1[typepiece] = terrain[newx, newy];
                terrain[newx, newy] = piece;
                Deplacement = true;
            }
            else if (typepiece == 3) findepartie = 1;


            if (Deplacement && (typepiece > -1) && (!(ReserveJ1[typepiece] == piece) || !(ReserveJ2[typepiece] == piece)))//si il y a deplacement et que la piece existe et que ce n'etait pas un parachutage alors on efface l'ancienne position
            {
                terrain[AncienePosition[0], AncienePosition[1]] = null;
                ZonePromoKod(piece,typepiece);
            }
        }

        public bool CheckCase(int posX, int posY, int NumJ)//retourne vrai si la case voulue et disponible et faux si non
        {
            if (posX > 3 || posX < 0 || posY > 2 || posY < 0)
            {
                return false;
            }
            else if ((terrain[posX, posY] == null) || terrain[posX, posY].NumJoueur != NumJ)
            {
                return true;
            }
            else return false;
        }

        private void ZonePromoKod(Pieces koda,int typepiece)
        {
            if ((terrain[koda.PositionX, koda.PositionY].GetType() == typeof(Kodama)))
            {
                terrain[koda.PositionX, koda.PositionY] = null;
                if (koda.NumJoueur == 1 && koda.PositionX == 0)
                {
                    
                    koda = new Kodama_Samurai(koda.PositionX, koda.PositionY, 1);
                    terrain[koda.PositionX, koda.PositionY] = koda;
                }
                else if (koda.NumJoueur == 2 && koda.PositionX == 3)
                {
                    koda = new Kodama_Samurai(koda.PositionX, koda.PositionY, 1);
                    terrain[koda.PositionX, koda.PositionY] = koda;
                }
            }

        }

        #region Methode de Test
        public void AfficheTestPlateau()
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= 2; j++)
                {
                    if (terrain[i, j] != null)
                    {
                        terrain[i, j].AfficheTestPiece();
                    }
                    else
                        Console.Write("None :(   x   )   |");
                }

            }
        }
        public void AfficheReserve()
        {
            Console.WriteLine();
            Console.WriteLine("ReserveJ1:");
            for (int i = 0; i < 3; i++)
            {
                if (ReserveJ1[i] != null) { Console.Write(i); }
                else Console.Write("X");
            }
            Console.WriteLine();
            Console.WriteLine("ReserveJ2:");
            for (int i = 0; i < 3; i++)
            {
                if (ReserveJ2[i] != null) { Console.Write(i); }
                else Console.Write("X");
            }
        }
        # endregion
    }
}