﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotheque
{
    public class Kodama_Samurai : Kodama
    {
        
        public Kodama_Samurai(int _posX, int _posY, int _numJ,string _img) : base(_posX, _posY, _numJ, _img)
        {
           
        }

        // Méthode
        public override int[,] CaseAccessible(Plateau plat)
        {
            int[,] caseAccesible = this.InitTableau();

            if (this.NumJoueur == 1)
            {
                if (plat.CheckCase(PositionX - 1, PositionY -1, this.NumJoueur))
                {
                    caseAccesible[PositionX - 1, PositionY -1] = 1;
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
            if (this.NumJoueur == 2)
            {
                if (plat.CheckCase(PositionX + 1, PositionY - 1, this.NumJoueur))
                {
                    caseAccesible[PositionX + 1, PositionY - 1] = 1;
                }
                if (plat.CheckCase(PositionX, PositionY + 1, this.NumJoueur))
                {
                    caseAccesible[PositionX, PositionY + 1] = 1;
                }
                if (plat.CheckCase(PositionX + 1, PositionY + 1, this.NumJoueur))
                {
                    caseAccesible[PositionX +1, PositionY + 1] = 1;
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