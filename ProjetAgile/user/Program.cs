﻿using ProjetAgile.bus;
using System;
using System.Collections.Generic;

namespace ProjetAgile.user
{
    internal class Program
    {
        static Game[] Game2 = new Game[10];
        static void Main(string[] args)
        {
            List<Player> playerList = new List<Player>();
            Player player;
            int i = 0;
            Game[] game1 = new Game[10];
            Game[] game2 = new Game[10];
            Game[] game3 = new Game[10];
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
                Console.Write("Option: ");
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
                    case 0:
                        {
                            
                            

                        }
                        break;


                    case 1:
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

        static void Jeux2()
        {
            Game2[0].Question = "Vrai ou Faux: Jerry West est le joueur présent sur le logo de la NBA ";
            Game2[0].Options = "Entrez 1 pour Vrai\n" + 
                "Entrez 2 pour Faux\n";
            Game2[0].Answer = '1';
            

            Game2[1].Question = "Parmis ces 3 pays, lequel a gagné la coupe du monde au soccer en 2022 ?";
            Game2[1].Options = " (a) France\n" +
                " (b) Maroc\n" +
                " (c) Argentine";
            Game2[1].Answer = 'c';

            Game2[2].Question = "De quelle catégorie de poid en boxe Mohammed Ali faisait-il parti?";
            Game2[2].Options = " (a) mi-lourd\n" +
                " (b) super-lourd\n" +
                " (c) lourd";
            Game2[2].Answer = 'c';

            Game2[3].Question = "En 2021, durant le Grand Chelem, au tennis, quelle joueuse a remporté l'Open d'Australie?";
            Game2[3].Options = "(a) Serena Williams\n" +
                " (b) Bianca Andreescu\n" +
                " (c) pour Naomi Osaka";
           Game2[3].Answer = 'c';

            Game2[4].Question = "Vrai ou Faux: Le joueur de soccer Ronaldinho Gaúcho est d'origine espagnole. ?";
            Game2[4].Options = "Entrez 1 pour Vrai\n" +
                "Entrez 2 pour Faux\n";
            Game2[4].Answer = '2';

            Game2[5].Question = "Vrai ou Faux:Les équipes à s'affonter durant les finales de la NBA en 2019 sont Toronto Raptors/Golden States Warriors";
            Game2[5].Options = "Entrez 1 pour Vrai\n" +
            "Entrez 2 pour Faux\n";
            Game2[5].Answer = '1';

            Game2[6].Question = "Quelle équipe de la NFL à recruté Tom Brady?";
            Game2[6].Options = "(a) Les Patriotes de la Nouvelle-Anglettre\n" +
                "(b) pour Les Wolverines du Michigan\n " +
                "(c) Entrez 3 pour Les Buccaneers de Tempa Bay";
            Game2[6].Answer = 'a';

            Game2[7].Question = "Quel joueur porte le surnom de 'GOAT' dans la NBA?";
            Game2[7].Options = "(a) Lamelo Ball\n" +
                "(b) Klay Thompson\n" +
                "(c) Michael Jordan";
            Game2[7].Answer = 'c';

            Game2[8].Question = "Quel athlète est considéré comme le plus grand sprinteur de tous les temps?";
            Game2[8].Options = "(a) Yohann Blake\n" +
                "(b) Usain Bolt\n" +
                "(c) pour Noah Lyles";
            Game2[8].Answer = 'b';

            Game2[9].Question = "Combien de championnat Michael Jordan a-t-il dans sa carrière dans la NBA?";
            Game2[9].Options = "(a) 6 championnats\n" +
                "(b) 7 championnats\n" +
                "(c) aucune de ces réponses";
            Game2[9].Answer = 'a';
        }
    }
}
