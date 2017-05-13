using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotheque
{
    public class Kitsune : Pieces
    {

        
        public Kitsune(int _posX, int _posY,int _numJ): base (_posX, _posY,_numJ)
        {  
        }

        // Méthode
        public int[,] CaseAccesible(Plateau plat)
        {
            int[,] CaseAccesible = new int[3, 2];
            CaseAccesible = null;
            if (plat.CheckCase(PositionX + 1, PositionY + 1,this.NumJoueur))
            {
                CaseAccesible[PositionX + 1, PositionY + 1] = 1;
            }
            if (plat.CheckCase(PositionX + 1, PositionY - 1, this.NumJoueur))
            {
                CaseAccesible[PositionX + 1, PositionY - 1] = 1;
            }
            if (plat.CheckCase(PositionX - 1, PositionY + 1, this.NumJoueur))
            {
                CaseAccesible[PositionX - 1, PositionY + 1] = 1;
            }
            if (plat.CheckCase(PositionX - 1, PositionY - 1, this.NumJoueur))
            {
                CaseAccesible[PositionX - 1, PositionY - 1] = 1;
            }
            return CaseAccesible;
        }
        //fonction en vb qui presente le tableau case accesible et qui renvoie les coordonées de la case choisie dans un tableau de 2 case
        public void Deplacement(int[] pos,Plateau plat)
        {
            int posX, posY;
            posX = pos[0];
            posY = pos[1];
            this.PositionX = posX;
            this.PositionY = posY;
            plat.SetPosition(this);

        }
    }
}