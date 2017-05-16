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
        private bool findepartie = false;

        //Constructeurs
        public Plateau() { }

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
            terrain[3, 0] = tanuj1;
            terrain[3, 1] = koroj1;
            terrain[3, 2] = kitsj1;
            terrain[2, 1] = kodj1;
            //Pieces joueur 2
            terrain[0, 0] = tanuj2;
            terrain[0, 1] = koroj2;
            terrain[0, 2] = kitsj2;
            terrain[1, 1] = kodj2;

            return terrain;
        }

        public int[] GetPosition(Pieces piece)//Permet de connaitre la position d'une piece sur le terrain de jeu
        {
            int[] TabPosition = new int[2];
            for (int i = 0; i == 1; i++) TabPosition[i] = 0;
            for (int i = 0; i <= 3; i++)
            { 
                for (int j = 0; j <= 2; j++)
                {
                    if (terrain[i, j] != null)
                    {
                        if (terrain[i,j] == piece)//verifie si les pieces sont identiques
                        {
                            TabPosition[0] = terrain[i, j].PositionX;
                            TabPosition[1] = terrain[i, j].PositionY;
                        }
                    }
                }
            }
            return TabPosition;
        }

        public void SetPosition(Pieces piece, int newx, int newy)//Permet de changer la position d'une pieces
        {
            int typepiece = -1;
            if (terrain[newx, newy] != null)
            {
                if (terrain[newx, newy].GetType() == typeof(Kitsune)) { typepiece = 0; }//determine la piece en question
                if (terrain[newx, newy].GetType() == typeof(Tanuki)) { typepiece = 1; }//afin de connaitre quel piece placer en reserve
                if (terrain[newx, newy].GetType() == typeof(Kodama)) { typepiece = 2; }
                if (terrain[newx, newy].GetType() == typeof(Koropokkuru)) { typepiece = 3; }
            }
            int[] AncienePosition = new int[2];
            AncienePosition = GetPosition(piece);
            piece.PositionX = newx;
            piece.PositionY = newy;
            bool Deplacement = false;//drapeau faux tant que le deplacement de la piece na pas etait acceptée
            
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
                terrain[newx,newy].NumJoueur = 1;
                ReserveJ1[typepiece] = terrain[newx, newy];
                terrain[newx, newy] = piece;
                Deplacement = true;
            }
            else if (typepiece == 3) findepartie = true;
            if (typepiece > -1)
            {
                if (Deplacement && !(ReserveJ1[typepiece] == piece) || !(ReserveJ2[typepiece] == piece))//si il y a eu deplacement, on efface l'ancienne position de la piece sur le terrain et on change les coordonées de la piece
                {
                    terrain[AncienePosition[0], AncienePosition[1]] = null;
                    piece.PositionX = newx;
                    piece.PositionY = newy;
                    if(typepiece == 2 && piece.NumJoueur == 1 && piece.PositionX == 0)
                        {
                        Kodama_Samurai KodSJ1 = new Kodama_Samurai(newx,newy,1,1);
                        terrain[newx, newy] = koSJ1;
                        }
                    else if (typepiece == 2 && piece.NumJoueur == 1 && piece.PositionX == 0)
                        {
                        Kodama_Samurai KodSJ2 = new Kodama_Samurai(newx, newy, 2, 0);
                        terrain[newx, newy] = koSJ2;
                    }
                }
            }

        }

        public bool CheckCase(int posX, int posY, int NumJ)//retourne vrais si la case voulus et disponible et faux si non
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

        public void Parachutage(Pieces para,int posX,int posY)
        {
            for(int i = 0;i <= 2; i++)
            {
                if(para.NumJoueur == 2)
                {
                    if (para == ReserveJ2[i])
                    {
                        SetPosition(para, posX, posY);
                        ReserveJ2[i] = null;
                    }
                }
                if (para.NumJoueur == 1)
                {
                    if (para == ReserveJ1[i])
                    {
                        SetPosition(para, posX, posY);
                        ReserveJ1[i] = null;
                    }
                }

            }
        }

        public void ZonePromo()
        {
            for(int i = 0; i <= 2; i++)
            {
                if(terrain[i] =
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