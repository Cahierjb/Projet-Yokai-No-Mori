﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotheque
{
    public class Plateau
    {
        //champs
        private InfoJoueur joueur1;//Création des variables joueurs 
        private InfoJoueur joueur2;
        private Pieces[,] terrain = new Pieces[4, 3];//création du terrain en tant que tableau de pieces
        private Pieces[] reserveJ1 = new Pieces[3];//Création des reserves en tant que tableau de pieces
        private Pieces[] reserveJ2 = new Pieces[3];
        private Kodama pointerKod1 = new Kodama(2,1,1, "kodama.jpg");//création des "pointeurs" qui désignent pour le moment les deux "kodama"
        private Kodama pointerKod2 = new Kodama(1,1,2, "kodama.jpg");
        private int findepartie = 0;
        int[] AncienePosition = new int[2];

        //Constructeurs
        public Plateau() { }

        //Propriétés
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
        public Pieces[,] Terrain
        {
            get { return this.terrain; }
        }
        public int Findepartie { get; set; }
        public InfoJoueur Joueur1 { get; set; }
        public InfoJoueur Joueur2 { get; set; }
        public Kodama PointerKod1 { get { return pointerKod1; } set { pointerKod1 =value; } }
        public Kodama PointerKod2 { get { return pointerKod2; } set { pointerKod2 = value; } }


        //Methodes
        public Pieces[,] initialisation(Tanuki tanuj1,Tanuki tanuj2,Kitsune kitsj1,Kitsune kitsj2,Koropokkuru koroj1, Koropokkuru koroj2, Kodama kodj1,Kodama kodj2)//instancie les pieces et les place a leur position initiale, vide également les reserves des joueurs
        {
            for (int i = 0; i == 2; i++) ReserveJ1[i] = null;
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
                        if (element == piece)//Verifie si les pieces sont identiques
                        {
                            TabPosition[0] = element.PositionX;
                            TabPosition[1] = element.PositionY;
                            break;
                        }
                    }
            }
            return TabPosition;
        }

        public void SetPosition(Pieces piece, int newx, int newy)//Permet de changer la position d'une "Piece"
        {
            int typepiece = -1;
            AncienePosition = GetPosition(piece);//avant de modifier l'emplacement de la Piece, on récupere son ancienne position 

            piece.PositionX = newx;//On change maintenant la position pour la piece elle même
            piece.PositionY = newy;

            bool Deplacement = false;//Boolean faux tant que le deplacement de la piece na pas etait acceptée
            bool Parachutage = false;

            if ((ReserveJ1.Contains(piece) || (ReserveJ2.Contains(piece))))//Si la piece passée en parametre de la méthode est dans la Reserve d'un des deux joueurs
                Parachutage = true;                                        //c'est qu'il s'agit d'un parachutage

            if (terrain[newx, newy] != null)//Si la case où l'on souhaite déplacer la Piece n'est pas vide, on récupere le type de la piece presente dans la case
            {
                if (terrain[newx, newy].GetType() == typeof(Kitsune)) { typepiece = 0; }//determine la piece en question
                if (terrain[newx, newy].GetType() == typeof(Tanuki)) { typepiece = 1; }//afin de connaitre quelle piece placée en reserve
                if (terrain[newx, newy].GetType() == typeof(Kodama) || terrain[newx, newy].GetType() == typeof(Kodama_Samurai)){ typepiece = 2; }
                if (terrain[newx, newy].GetType() == typeof(Koropokkuru)) { typepiece = 3; }
            }

            if (terrain[newx, newy] == null)// cas ou la case est vide
            {
                terrain[newx, newy] = piece;//on definit sa nouvelle position uniquement
                Deplacement = true;
            }
            else if (terrain[newx, newy].NumJoueur == 1 && !(typepiece == 3) && Parachutage == false)//cas ou la case appartient au joueur adverse j1    
            {
                terrain[newx, newy].NumJoueur = 2;//on change le joueur propriétaire de la piece
                if (terrain[newx, newy].GetType() == typeof(Kodama_Samurai))
                {
                    pointerKod2 = new Kodama(terrain[newx, newy].PositionX, terrain[newx, newy].PositionY, terrain[newx, newy].NumJoueur, "kodama.jpg");
                    terrain[newx, newy] = pointerKod2;//on verifie s'il sagit d'un kodama samurai, si c'est le cas on le cast en simple kodama
                }
                ReserveJ2[typepiece] = terrain[newx, newy];//on stocke la piece du joueur adverse dans la reserve 
                terrain[newx, newy] = piece;//puis on place la piece du j2 dans la case
                Deplacement = true;
            }
            else if (terrain[newx, newy].NumJoueur == 2 && !(typepiece == 3) && Parachutage==false)//cas ou la case appartient au joueur adverse j2
            {
                terrain[newx, newy].NumJoueur = 1;
                if (terrain[newx, newy].GetType() == typeof(Kodama_Samurai))
                {
                    pointerKod1 = new Kodama(terrain[newx, newy].PositionX, terrain[newx, newy].PositionY, terrain[newx, newy].NumJoueur, "kodama.jpg");
                    terrain[newx, newy] = pointerKod1;//
                }
                ReserveJ1[typepiece] = terrain[newx, newy];
                terrain[newx, newy] = piece;
                Deplacement = true;
            }
            if (typepiece == 3)//cas ou la case attaquée contient un Koropokkuru
            {
                Findepartie = 1;
                if(piece.NumJoueur == 1) { joueur1.Gagnant = true; }
                else { joueur2.Gagnant = true; }
                terrain[newx, newy] = piece;
                terrain[AncienePosition[0], AncienePosition[1]] = null;
            }

            if (Deplacement)//si il y a deplacement et que ce n'etait pas un parachutage alors on efface l'ancienne position
            {
                if (!Parachutage)terrain[AncienePosition[0], AncienePosition[1]] = null;
                if(piece.Position()== 3)//Puis on verifie que la piece qui se deplace na pas fais trois aller-retour
                {
                    Findepartie = 4;
                    joueur1.Gagnant = true;
                    joueur2.Gagnant = true;

                }
            }
            ZonePromo(piece, Parachutage);//Enfin On verifie le contenu de la zone de promotion afin de savoir si il y a un kodama a transformer ou si le koropokkuru est dans la zone
            Deplacement = false;
            Parachutage = false;
        }

        public bool CheckCase(int posX, int posY, int NumJ)//retourne vrai si la case voulue et disponible et faux sinon
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

        private void ZonePromo(Pieces dernierePieceJouée,bool para)//Méthode qui verifie la piece qui se trouve dans la zone de promotion afin d'appliquer les régles qui la concerne 
        {
            Pieces piece;
            for (int i = 0; i < 2  ; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    piece = Terrain[i * 3, j];
                    if (piece != null)
                    { 
                            if ((piece.GetType() == typeof(Kodama) && para == false))//si il s'agit d'un Kodama
                            {
                                if (piece.NumJoueur == 1 && piece.PositionX == 0)//qu'il appartient au joueur 1 et qu'il est dans sa zone de promotion
                                {
                                    piece = new Kodama_Samurai(piece.PositionX, piece.PositionY, 1, "kodama_sam.jpg");//alors on instancie le Kodama_Samurai
                                    PointerKod2 = (Kodama_Samurai)piece;//et on fait pointer le "pointeur" sur celui-ci
                                    terrain[piece.PositionX, piece.PositionY] = PointerKod2;
                                }
                                else if (piece.NumJoueur == 2 && piece.PositionX == 3)
                                {
                                    piece = new Kodama_Samurai(piece.PositionX, piece.PositionY, 2, "kodama_sam.jpg");
                                    PointerKod1 = (Kodama_Samurai)piece;
                                    terrain[piece.PositionX, piece.PositionY] = PointerKod1;
                                }
                            }
                            else if (piece.GetType() == typeof(Koropokkuru))//si il s'agit d'un Koropokkuru
                            {

                             if (piece.NumJoueur == 1 && piece.PositionX == 0 && AncienePosition[0] == 0 && dernierePieceJouée.NumJoueur == 2)
                                {
                                    Findepartie = 2;
                                    Joueur1.Gagnant = true;

                                }
                                else if (piece.NumJoueur == 2 && piece.PositionX == 3 && AncienePosition[0] == 3 && dernierePieceJouée.NumJoueur == 1)
                                {
                                    Findepartie = 2;
                                    Joueur2.Gagnant = true;
                                }
                            }
                       }
                    }
                }

        }

        public void initJoueur(InfoJoueur j1,InfoJoueur j2)//Méthode qui instancie le joueur avec les informations obtenues dans le programme principal et qui determine le joueur qui commence
        {
            joueur1 = j1;
            joueur2 = j2;
            Random rand = new Random();
            var num = rand.Next(1, 3);
            if (num == 1)
                joueur1.Commence = true;
            if (num == 2)
                joueur2.Commence = true;
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