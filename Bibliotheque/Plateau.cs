using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotheque
{
    public class Plateau
    {
        //champs
        private Pieces[,] terrain= new Pieces [3, 4];
 
        //Propriétés
        public Pieces[,] Terrain
        {
            get
            {
                return terrain;
            }
        }

        //Constructeurs
        public Plateau(Pieces[,] terr)
        {
            terrain = terr;
        }

        //Methodes
        public Pieces[,] initialisation()
        {
            Kitsune kitsj1 = new Kitsune();
            Kodama  kodj1 = new Kodama();
            Koropokkuru koroj1= new Koropokkuru();
            Tanuki tanuj1 = new Tanuki();
            Kitsune kitsj2 = new Kitsune();
            Kodama kodj2 = new Kodama();
            Koropokkuru koroj2 = new Koropokkuru();
            Tanuki tanuj2 = new Tanuki();
            terrain[0,0] = tanuj2;
            terrain[0,1] = koroj2;
            terrain[0,2] = kitsj2;
            terrain[1,1] = kodj2;
            terrain[3,0] = tanuj1;
            terrain[3,1] = koroj1;
            terrain[3,2] = kitsj1;
            terrain[2,1] = kodj1;
            return terrain;
        }


    }
}