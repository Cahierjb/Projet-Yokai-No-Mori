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
        private bool aller = false;
        private bool retour = false;

        //Propriétées
        public int Compteur{ get; set; }

        public Kodama(int _posX, int _posY, int _numJ) : base(_posX, _posY, _numJ)
        {
        }
        // Méthode
        public int[,] CaseAccesible(Plateau plat)
        {
            int[,] caseAccesible = this.InitTableau();

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

    }
}