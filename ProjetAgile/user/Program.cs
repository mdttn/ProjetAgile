using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using ProjetAgile.bus;

namespace ProjetAgile.user
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> playerList = new List<Player>();
            Player player1 = new Player();
            Player player2 = new Player();
            Player player3 = new Player();
            Player[] players = new Player[5];
            Game[] game1 = new Game[10];
            Game[] game2 = new Game[10];
            Game[] game3 = new Game[10];
            int option;

            // head title
            Console.WriteLine("BIENVENUE AU JEU ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\"Who wants to be a millionaire?\"");
            Console.ResetColor();
            Console.WriteLine("!\n");

        label1:
            // start menu
            Console.WriteLine("MENU");
            Console.WriteLine("[1] Inscription");
            Console.WriteLine("[2] Leaderboard");
            Console.WriteLine("[3] Quitter");
            Console.Write("Option: ");
            try
            {
                option = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nOption invalide.\n");
                goto label1;
            }

            do
            {
                Console.Write("Votre prénom: ");
                player1.FirstName = Console.ReadLine();
            }
            while (player1.FirstName == "");

            do
            {
                Console.Write("Votre nom de famille: ");
                player1.LastName = Console.ReadLine();
            }
            while (player1.LastName == "");

        label2:
            Console.Write("Votre âge: ");
            try
            {
                player1.Age = Convert.ToInt32(Console.ReadLine());
                if (player1.Age < 18)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nVous êtes trop jeune pour participer.\n");
                    Console.ResetColor();
                    Console.Clear();

                }
                else
                {
                    playerList.Add(player1);
                    Console.WriteLine("\nJOUEUR #1: " + player1.GetState() + "\n");
                    //
                    Console.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto label2;
            }

            Console.ReadKey();
        }
    }
}
