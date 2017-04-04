using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class HelloWorld
    {
        public HelloWorld(string prenom)
        {
            this.Prenom = prenom;
        }

        private string _prenom;

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public string Bonjour
        {
            get
            {
                return string.Format("Bonjour {0}, il est {1:dd/MM/yyyy H:mm:ss zzz}", Prenom, new DateTime());
            }
        }
    }
}
