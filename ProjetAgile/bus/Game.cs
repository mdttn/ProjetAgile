using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAgile.bus
{
    public struct Game
    {
        private string question;
        private string options;
        private char answer;

        public string Question
        {
            get { return this.question; }
            set { this.question = value; }
        }

        public string Options
        {
            get { return this.options; }
            set { this.options = value; }
        }

        public char Answer
        {
            get { return this.answer; }
            set { this.answer = value; }
        }

        public string GetAnswer()
        {
            string answer;
            answer = "La bonne réponse est: " + this.answer;
            return answer;
        }
    }
}
