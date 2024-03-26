using ProjetAgile.bus;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;

namespace ProjetAgile.user
{
    internal class Program
    {
        static Game[] game1 = new Game[10];
        static Game[] game2 = new Game[10];
        static Game[] game3 = new Game[10];

        static void Main(string[] args)
        {
            List<Player> playerList = new List<Player>();
            Player player;
            int i = 0;
            int option;

            do
            {
                player = new Player();
                option = 0;

                Console.Clear();
                // head title
                Console.WriteLine("BIENVENUE AU JEU ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\"Who wants to be a millionaire?\"\n");
                Console.ResetColor();

                // start menu
                Console.WriteLine("MENU");
                Console.WriteLine("[1] Inscription");
                Console.WriteLine("[2] Leaderboard");
                Console.WriteLine("[3] Quitter");
                Console.Write("=> ");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());                    
                }
                catch (Exception)
                {
                    // message de default
                }
                Console.WriteLine();

                switch (option)
                {
                    case 1:
                        char start = ' ';
                        
                        do
                        {
                            Console.Write("Votre prénom: ");
                            player.FirstName = Console.ReadLine();
                        }
                        while (player.FirstName == "");

                        do
                        {
                            Console.Write("Votre nom de famille: ");
                            player.LastName = Console.ReadLine();
                        }
                        while (player.LastName == "");

                    label1:
                        Console.Write("Votre âge: ");
                        try
                        {
                            player.Age = Convert.ToInt32(Console.ReadLine());
                            if (player.Age < 18)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nVous êtes trop jeune pour participer.");
                                Console.ResetColor();
                                Console.ReadLine();
                            }
                            else
                            {
                                i++;
                                playerList.Add(player);
                                Console.WriteLine($"\nJoueur {i}: {player.GetState()}");
                                Console.ReadLine();
                                Console.Clear();

                                Console.Write("Voulez-vous commencer maintenant? (y/n) ");
                                do
                                {
                                    switch (start)
                                    {
                                        case 'y':
                                            Game1();
                                            break;
                                        case 'n':
                                            playerList.Remove(player);
                                            i--;
                                            break;
                                        default:
                                            // reset
                                            break;
                                    }
                                }
                                while (start != 'n');
                            }
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nÂge invalide.\n");
                            Console.ResetColor();
                            goto label1;
                        }
                        break;
                    case 2:
                        foreach (Player p in playerList)
                        {
                            Console.WriteLine($"{p.GetState()}");
                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nCliquez 2 fois pour quitter.");
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Option invalide.");
                        Console.ResetColor();
                        Console.ReadLine();
                        break;
                }                
            }
            while (option != 3);            

            Console.ReadKey();
        }

        static void Game1()
        {
            game2[0].Question = "Vrai ou Faux: Le tyrannosaure est l'emblème de Jurassic Park ";
            game2[0].Options = "Entrez 1 pour Vrai\n" + 
                "Entrez 2 pour Faux\n";
            game2[0].Answer = '1';
            

            game2[1].Question = "Combien d'étoiles sont présents sur le drapeau des États-Unis ?";
            game2[1].Options = 
                " (a) 50 \n" +
                " (b) 51 \n" +
                " (c) 52\n" +
                " (d) Aucune de ces réponses ";
            game2[1].Answer = 'a';

            game2[2].Question = "De quelle catégorie de poid en boxe Mohammed Ali faisait-il parti?";
            game2[2].Options = 
                " (a) \n" +
                " (b) \n" +
                " (c) \n" +
                " (d) ";
            game2[2].Answer = 'c';

            game2[3].Question = "Vrai ou Faux :";
            game2[3].Options = 
                " Entrez 1 pour vrai\n" +
                " Entrez 2 pour faux";
            game2[3].Answer = 'c';

            game2[4].Question = "Quel est la formule brut du glucose (sucre)?";
            game2[4].Options = 
                " (a) ( C6/H12/O6 )\n" +
                " (b) ( C2/H6/O )\n" +
                " (c) ( N/O3 )" +
                " (d) ";
            game2[4].Answer = 'a';

            game2[5].Question = "Vrai ou Faux :";
            game2[5].Options = "Entrez 1 pour Vrai\n" +
            "Entrez 2 pour Faux\n";
            game2[5].Answer = '1';

            game2[6].Question = "Quel pays ne fait pas parti de l'OTAN ?";
            game2[6].Options = 
                " (a) Slovaquie \n" +
                " (b) Slovénie\n " +
                " (c) Vatican" +
                " (d) "; 
            game2[6].Answer = 'c';

            game2[7].Question = " ?";
            game2[7].Options = 
                " (a)\n" +
                " (b)\n" +
                " (c)\n " +
                " (d)\n";
            game2[7].Answer = 'c';

            game2[8].Question = "Quel athlète est considéré comme le plus grand sprinteur de tous les temps?";
            game2[8].Options = 
                " (a) Yohann Blake\n" +
                " (b) Usain Bolt\n" +
                " (c) pour Noah Lyles\n" +
                " (d) ";
            game2[8].Answer = 'b';

            game2[9].Question = "Combien de championnat Michael Jordan a-t-il dans sa carrière dans la NBA?";
            game2[9].Options = 
                " (a) 6 championnats\n" +
                " (b) 7 championnats\n" +
                " (c)\n"+
                " (d) aucune de ces réponses";
            game2[9].Answer = 'a';
        }
    }
}
