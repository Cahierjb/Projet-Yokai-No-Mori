using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotheque
{
    public class Kitsune : Pieces
    {

        
        public Kitsune(int _posX, int _posY): base (_posX, _posY)
        {  
        }

        // Méthode
        protected void CaseAccesible()
        {
            int[,] CaseAccesible = new int[3, 4];
            if (Plat.terrain[PositionX + 1,PositionY +1] != null )
            {
                CaseAccesible[PositionX + 1, PositionY + 1] = 1;
            }
            if (Plat.terrain[PositionX + 1, PositionY - 1] != null)
            {
                CaseAccesible[PositionX + 1, PositionY - 1] = 1;
            }
            if (Terrain[PositionX - 1, PositionY + 1] != null)
            {
                CaseAccesible[PositionX - 1, PositionY + 1] = 1;
            }
            if (Terrain[PositionX - 1, PositionY - 1] != null)
            {
                CaseAccesible[PositionX - 1, PositionY - 1] = 1;
            }
        }
        protected void Deplacement()
        {

        }
    }
}