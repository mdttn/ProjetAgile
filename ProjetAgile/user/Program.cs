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
            Game[] game1 = new Game[10];
            Game[] game2 = new Game[10];
            Game[] game3 = new Game[10];

            Console.WriteLine("BIENVENUE au jeu \"Who wants to be a millionaire?\"\n");
            do
            {
                Console.Write("Votre prénom: ");
                player1.FirstName = Console.ReadLine();
            }
            while (player1.FirstName == null);

            do
            {
                Console.Write("Votre nom de famille: ");
                player1.LastName = Console.ReadLine();
            }
            while (player1.LastName == null);

        label1:
            Console.Write("Votre âge: ");
            try
            {
                player1.Age = Convert.ToInt32(Console.ReadLine());
                if (player1.Age < 18)
                {
                    Console.WriteLine("Vous êtes trop jeune pour participer.\n");
                }
                else
                {
                    playerList.Add(player1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto label1;
            }
        }
    }
}
