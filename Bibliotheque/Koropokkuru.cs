﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotheque
{
    public class Koropokkuru : Pieces
    {
        public Koropokkuru(int _posX, int _posY, int _numJ, string _img) : base(_posX, _posY, _numJ,_img)
            {
            }

        // Méthode
        public override int[,] CaseAccessible(Plateau plat)
        {
            int[,] caseAccesible = this.InitTableau();

            if (plat.CheckCase(PositionX + 1, PositionY + 1, this.NumJoueur))
            {
                caseAccesible[PositionX + 1, PositionY + 1] = 1;
            }
            if (plat.CheckCase(PositionX + 1, PositionY - 1, this.NumJoueur))
            {
                caseAccesible[PositionX + 1, PositionY - 1] = 1;
            }
            if (plat.CheckCase(PositionX + 1, PositionY + 0, this.NumJoueur))
            {
                caseAccesible[PositionX + 1, PositionY + 0] = 1;
            }
            if (plat.CheckCase(PositionX - 1, PositionY + 1, this.NumJoueur))
            {
                caseAccesible[PositionX - 1, PositionY + 1] = 1;
            }
            if (plat.CheckCase(PositionX - 1, PositionY - 1, this.NumJoueur))
            {
                caseAccesible[PositionX - 1, PositionY - 1] = 1;
            }
            if (plat.CheckCase(PositionX - 1, PositionY + 0, this.NumJoueur))
            {
                caseAccesible[PositionX - 1, PositionY + 0] = 1;
            }
            if (plat.CheckCase(PositionX + 0, PositionY + 1, this.NumJoueur))
            {
                caseAccesible[PositionX + 0, PositionY + 1] = 1;
            }
            if (plat.CheckCase(PositionX + 0, PositionY - 1, this.NumJoueur))
            {
                caseAccesible[PositionX + 0, PositionY - 1] = 1;
            }
            return caseAccesible;
        }
    }
}