using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAgile.bus
{
    internal class Joueurs
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName 
        { 
            get { return this.firstName; } 
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public Player()
        {
            this.firstName = "Unknown";
            this.lastName = "Unknown";
            this.age = 0;

        }
        public Player(string prenom, string nom, int age) 
        {
            this.firstName = prenom;
            this.lastName = nom;
            this.age = age;
        }
        public void SetName(string firstName)
        {
            this.firstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public string GetFirstName() 
        { 
            return this.firstName; 
        }

        public string GetLastName()
        {
            return this.lastName;
        }

        public int GetAge()
        {
            return this.age;
        }

        public string GetSate()
        {
            string state;
            state = this.firstName + " " + this.lastName + " | " + this.age;
            return state;
        }

        
    }
}
