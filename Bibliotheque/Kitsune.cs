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
        protected void CaseAccesible()
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
        }
        protected void Deplacement(int posX,int posY)
        {
            this.PositionX = posX;
            this.PositionY = posY;
            plat.SetPosition(this);

        }
    }
}