using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAgile.bus
{
    internal class Joueurs
    {
        private string prenom;
        private string nom;
        private int age;

        public string Prenom 
        { 
            get { return this.prenom; } 
            set { this.prenom = value; }
        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public Player() { }
    }
}
