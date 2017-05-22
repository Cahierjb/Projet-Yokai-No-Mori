using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotheque
{
    public class InfoJoueur
    {
        //champs
        private string nomJoueur;
        private int numJoueur;
        private bool gagnant;


        //propriétées
        public string NomJoueur
        {
            get { return nomJoueur; }
            set { nomJoueur = value; }
        }
        public int NumJoueur
        {
            get { return numJoueur; }
            set { numJoueur = value; }
        }
        public bool Gagnant
        {
            get { return gagnant; }
            set { gagnant = value; }
        }

        //constructeurs
        public  InfoJoueur(string nomj,int numj)
        {
            nomJoueur = nomj;
            numJoueur = numj;
        }

    }
}