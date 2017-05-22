using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotheque
{
    public class Kodama : Pieces
    {
        //champs
        private int compteur = 0;
        private bool changeposition = true;

        //Propriétées
        public int Compteur{ get; set; }

        public Kodama(int _posX, int _posY, int _numJ) : base(_posX, _posY, _numJ)
        {
        }
        // Méthode
        public int[,] CaseAccesible(Plateau plat)
        {
            int[,] caseAccesible = new int[4, 3];
            for (int i = 0; i == 3; i++)
            {
                for (int j = 0; j == 2; j++)
                {
                    caseAccesible[i, j] = 0;
                }
            }

            if (this.NumJoueur == 1)
            {
                if (plat.CheckCase(PositionX + 0, PositionY + 1, this.NumJoueur))
                {
                    caseAccesible[PositionX + 0, PositionY + 1] = 1;
                }
            }
            if (this.NumJoueur == 2)
            {
                if (plat.CheckCase(PositionX + 0, PositionY - 1, this.NumJoueur))
                {
                    caseAccesible[PositionX + 0, PositionY - 1] = 1;
                }
            }
            return caseAccesible;
        }

        public void Position()
        {
            if(this.PositionX == 0 && changeposition)
            {
                compteur++;
                changeposition = false;
            }
            else if (changeposition == false && compteur > 0)
            {   
                if(this.PositionX != 0)
                {
                    changeposition = true;
                }

            }

        }
        //fonction en vb qui presente le tableau case accesible et qui renvoie les coordonées de la case choisie 

    }
}