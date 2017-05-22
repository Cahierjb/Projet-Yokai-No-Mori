using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotheque
{
    public class Kodama_Samurai : Kodama
    {
        protected bool sens;
        public Kodama_Samurai(int _posX, int _posY, int _numJ, bool _sens) : base(_posX, _posY, _numJ)
        {
            sens = _sens;
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
            if (sens == false)
            {
                if (plat.CheckCase(PositionX + 1, PositionY + 1, this.NumJoueur))
                {
                    caseAccesible[PositionX + 1, PositionY + 1] = 1;
                }
                if (plat.CheckCase(PositionX + 0, PositionY + 1, this.NumJoueur))
                {
                    caseAccesible[PositionX + 0, PositionY + 1] = 1;
                }
                if (plat.CheckCase(PositionX - 1, PositionY + 1, this.NumJoueur))
                {
                    caseAccesible[PositionX - 1, PositionY + 1] = 1;
                }
                if (plat.CheckCase(PositionX - 1, PositionY + 0, this.NumJoueur))
                {
                    caseAccesible[PositionX - 1, PositionY + 0] = 1;
                }
                if (plat.CheckCase(PositionX + 1, PositionY + 0, this.NumJoueur))
                {
                    caseAccesible[PositionX + 1, PositionY + 0] = 1;
                }
                if (plat.CheckCase(PositionX + 0, PositionY - 1, this.NumJoueur))
                {
                    caseAccesible[PositionX + 0, PositionY - 1] = 1;
                }
            }
            if (sens == true)
            {
                if (plat.CheckCase(PositionX + 1, PositionY - 1, this.NumJoueur))
                {
                    caseAccesible[PositionX + 1, PositionY - 1] = 1;
                }
                if (plat.CheckCase(PositionX + 0, PositionY + 1, this.NumJoueur))
                {
                    caseAccesible[PositionX + 0, PositionY + 1] = 1;
                }
                if (plat.CheckCase(PositionX - 1, PositionY - 1, this.NumJoueur))
                {
                    caseAccesible[PositionX - 1, PositionY - 1] = 1;
                }
                if (plat.CheckCase(PositionX - 1, PositionY + 0, this.NumJoueur))
                {
                    caseAccesible[PositionX - 1, PositionY + 0] = 1;
                }
                if (plat.CheckCase(PositionX + 1, PositionY + 0, this.NumJoueur))
                {
                    caseAccesible[PositionX + 1, PositionY + 0] = 1;
                }
                if (plat.CheckCase(PositionX + 0, PositionY - 1, this.NumJoueur))
                {
                    caseAccesible[PositionX + 0, PositionY - 1] = 1;
                }
            }
            return caseAccesible;
        }

    }
}