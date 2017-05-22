﻿using System;
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
            int[,] caseAccesible = this.InitTableau();

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

        //fonction en vb qui presente le tableau case accesible et qui renvoie les coordonées de la case choisie 

    }
}