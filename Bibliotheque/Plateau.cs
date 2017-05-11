using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotheque
{
    public class Plateau
    {
        //champs
        private Pieces[,] terrain = new Pieces[3, 2];
        private Pieces[] ReserveJ1 = new Pieces[2];
        private Pieces[] ReserveJ2 = new Pieces[2];


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
        public Pieces[,] initialisation()//instancie les pieces et les place a leurs position initiale, vide également les reserves des joueurs
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
        public int[] GetPosition(Pieces piece)//Permet de connaitre la position d'une piece sur le terrain de jeu
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
        public void SetPosition(Pieces piece)//Permet de changer la position d'une pieces
        {
            int[] AncienePosition = GetPosition(piece);
            bool Deplacement = false;//drapeau faux tant que le deplacement de la piece na pas etait acceptée
            int typepiece = 0;
            if (CheckCase(piece.PositionX,piece.PositionY,piece.NumJoueur))// cas ou la case est vide
            {
                terrain[piece.PositionX, piece.PositionY] = piece;
                Deplacement = true;
            }
            if (piece.GetType() == typeof(Kitsune)) typepiece = 0;//determine la piece en question
            if (piece.GetType() == typeof(Tanuki)) typepiece = 1;//afin de connaitre quel piece placer en reserve
            if (piece.GetType() == typeof(Kodama)) typepiece = 2;
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

        public bool CheckCase(int posX, int posY,int NumJ)//retourne vrais si la case voulus et disponible et faux si non
        {
            if ((terrain[posX, posY] == null) || terrain[posX, posY].NumJoueur != NumJ)
            {
                return true;
            }
            else return false;
        }



    }
}