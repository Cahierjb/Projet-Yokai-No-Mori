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
        private Pieces[] ReserveJ1 = new Pieces[2];
        private Pieces[] ReserveJ2 = new Pieces[2];


        //Propriétés

        //Constructeurs
        public Plateau() { }

        //Methodes
        public Pieces[,] initialisation(Tanuki tanuj1,Tanuki tanuj2,Kitsune kitsj1,Kitsune kitsj2,Koropokkuru koroj1, Koropokkuru koroj2, Kodama kodj1,Kodama kodj2)//instancie les pieces et les place a leurs position initiale, vide également les reserves des joueurs
        {
            for (int i = 0;i==2 ; i++) ReserveJ1[i] = null;
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
                        if (terrain[i, j].PositionX == piece.PositionX && terrain[i, j].PositionY == piece.PositionY && terrain[i, j].NumJoueur == piece.NumJoueur)
                        {
                            TabPosition[0] = terrain[i, j].PositionX;
                            TabPosition[1] = terrain[i, j].PositionY;
                        }
                    }
                }
            }
            return TabPosition;
        }
        public void SetPosition(Pieces piece,int newx,int newy)//Permet de changer la position d'une pieces
        {
            int[] AncienePosition = new int[2];
            AncienePosition = GetPosition(piece);
            piece.PositionX = newx;
            piece.PositionY = newy;
            bool Deplacement = false;//drapeau faux tant que le deplacement de la piece na pas etait acceptée
            int typepiece = 0;
            if (piece.GetType() == typeof(Kitsune)) { typepiece = 0; }//determine la piece en question
            if (piece.GetType() == typeof(Tanuki)) { typepiece = 1; }//afin de connaitre quel piece placer en reserve
            if (piece.GetType() == typeof(Kodama)) { typepiece = 2; }
            if (CheckCase(piece.PositionX, piece.PositionY, piece.NumJoueur))// cas ou la case est vide
            {
                terrain[piece.PositionX, piece.PositionY] = piece;
                Deplacement = true;
            }
            else if (piece.NumJoueur == 1)//cas ou la case appartient au joueur adverse si le joueur est le joueur 1
            {
                ReserveJ2[typepiece] = terrain[piece.PositionX, piece.PositionY];
                Deplacement = true;
            }
            else if (piece.NumJoueur == 2)//cas ou la case appartient au joueur adverse si le joueur est le joueur 2
            {
                ReserveJ1[typepiece] = terrain[piece.PositionX, piece.PositionY];
                Deplacement = true;
            }
            if (Deplacement)//si il y a eu deplacement, on efface l'ancienne position de la piece sur le terrain
            {
                terrain[AncienePosition[0], AncienePosition[1]] = null;
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
                        Console.Write("(   x   )");
                }

            }
        }
    }
}