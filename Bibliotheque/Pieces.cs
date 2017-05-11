using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotheque
{
    public class Pieces
    {
        // Champs
        private int positionX;
        private int positionY;
        private Plateau plat = new Plateau();

        // Constructeur
        public Pieces(int _posX, int _posY)
        {
            positionX = _posX;
            positionY = _posY;
        }

        // Propriétés
        public string Nom { get; set; }
        public int PositionX { get { return positionX; }}
        public int PositionY { get { return positionX; }}
        public Plateau Plat { get { return plat; }}


        // Méthode

    }
}