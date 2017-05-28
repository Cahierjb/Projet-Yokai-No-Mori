using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotheque
{
    public class Kodama : Pieces
    {

        public Kodama(int _posX, int _posY, int _numJ,string _img) : base(_posX, _posY, _numJ,_img)
        {
        }

        // Méthode
        public override int[,] CaseAccessible(Plateau plat)
        {
            int[,] caseAccesible = this.InitTableau();

            if (this.NumJoueur == 1)
            {
                if (plat.CheckCase(PositionX-1, PositionY, this.NumJoueur))
                {
                    caseAccesible[PositionX-1, PositionY] = 1;
                }
            }
            else if (this.NumJoueur == 2)
            {
                if (plat.CheckCase(PositionX+1, PositionY, this.NumJoueur))
                {
                    caseAccesible[PositionX+1, PositionY] = 1;
                }
            }
            return caseAccesible;
        }

        //fonction en vb qui presente le tableau case accesible et qui renvoie les coordonées de la case choisie 

    }
}