using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotheque
{
    public class Pieces
    {
        // Champs
        private string nom;
        private int[,] position;


        // Constructeur
        public Pieces(string _nom, int[,] _pos)
        {
            Nom = _nom;
            Position = _pos;
        }

        // Propriétés
        public string Nom { get; set; }
        public int[,] Position { get; set; }


        // Méthode

    }
}