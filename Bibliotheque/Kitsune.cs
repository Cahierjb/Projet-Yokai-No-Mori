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
            int[,] caseAccesible = new int[4, 3];
            for (int i = 0; i == 3; i++)
            {
                for (int j = 0; j == 2; j++)
                {
                    caseAccesible[i, j] = 0;
                }

            }
            if (plat.CheckCase(PositionX + 1, PositionY + 1,this.NumJoueur))
            {
                caseAccesible[PositionX + 1, PositionY + 1] = 1;
            }
            if (plat.CheckCase(PositionX + 1, PositionY - 1, this.NumJoueur))
            {
                caseAccesible[PositionX + 1, PositionY - 1] = 1;
            }
            if (plat.CheckCase(PositionX - 1, PositionY + 1, this.NumJoueur))
            {
                caseAccesible[PositionX - 1, PositionY + 1] = 1;
            }
            if (plat.CheckCase(PositionX - 1, PositionY - 1, this.NumJoueur))
            {
                caseAccesible[PositionX - 1, PositionY - 1] = 1;
            }
            return caseAccesible;
        }
        public void Deplacement(int posX, int posY, Plateau plat)
        {
            plat.SetPosition(this, posX, posY);

        }
    }
}