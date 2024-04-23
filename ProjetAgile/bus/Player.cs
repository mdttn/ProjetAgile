using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAgile.bus
{
    public class Player
    {
        private string firstName;
        private string lastName;
        private int age;
        private int money;

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

        public int Money
        {
            get { return this.money; }
            set { this.money = value; }
        }

        public Player()
        {
            this.firstName = "Unknown";
            this.lastName = "Unknown";
            this.age = 0;
            this.money = 0;
        }

        public Player(string prenom, string nom, int age, int money) 
        {
            this.firstName = prenom;
            this.lastName = nom;
            this.age = age;
            this.money = money;
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

        public void SetMoney(int money)
        {
            this.money = money;
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

        public int GetMoney()
        {
            return this.money;
        }

        public string GetState()
        {
            string state;
            state = this.firstName + " " + this.lastName + ", " + this.age + " ans";
            return state;
        }

        public string GetResult()
        {
            string res;
            res = this.firstName + " " + this.lastName + ", " + this.age + " ans" + "\t(" + this.money + ")";
            return res;
        }
    }
}
