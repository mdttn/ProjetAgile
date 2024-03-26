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
                                            Game2();
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

        static void Game2()
        {
            game2[0].Question = "Vrai ou Faux: Jerry West est le joueur présent sur le logo de la NBA ";
            game2[0].Options = "Entrez 1 pour Vrai\n" + 
                "Entrez 2 pour Faux\n";
            game2[0].Answer = '1';
            

            game2[1].Question = "Parmis ces 3 pays, lequel a gagné la coupe du monde au soccer en 2022 ?";
            game2[1].Options = " (a) France\n" +
                " (b) Maroc\n" +
                " (c) Argentine";
            game2[1].Answer = 'c';

            game2[2].Question = "De quelle catégorie de poid en boxe Mohammed Ali faisait-il parti?";
            game2[2].Options = " (a) mi-lourd\n" +
                " (b) super-lourd\n" +
                " (c) lourd";
            game2[2].Answer = 'c';

            game2[3].Question = "En 2021, durant le Grand Chelem, au tennis, quelle joueuse a remporté l'Open d'Australie?";
            game2[3].Options = "(a) Serena Williams\n" +
                " (b) Bianca Andreescu\n" +
                " (c) pour Naomi Osaka";
            game2[3].Answer = 'c';

            game2[4].Question = "Vrai ou Faux: Le joueur de soccer Ronaldinho Gaúcho est d'origine espagnole. ?";
            game2[4].Options = "Entrez 1 pour Vrai\n" +
                "Entrez 2 pour Faux\n";
            game2[4].Answer = '2';

            game2[5].Question = "Vrai ou Faux:Les équipes à s'affonter durant les finales de la NBA en 2019 sont Toronto Raptors/Golden States Warriors";
            game2[5].Options = "Entrez 1 pour Vrai\n" +
            "Entrez 2 pour Faux\n";
            game2[5].Answer = '1';

            game2[6].Question = "Quelle équipe de la NFL à recruté Tom Brady?";
            game2[6].Options = "(a) Les Patriotes de la Nouvelle-Anglettre\n" +
                "(b) pour Les Wolverines du Michigan\n " +
                "(c) Entrez 3 pour Les Buccaneers de Tempa Bay";
            game2[6].Answer = 'a';

            game2[7].Question = "Quel joueur porte le surnom de 'GOAT' dans la NBA?";
            game2[7].Options = "(a) Lamelo Ball\n" +
                "(b) Klay Thompson\n" +
                "(c) Michael Jordan";
            game2[7].Answer = 'c';

            game2[8].Question = "Quel athlète est considéré comme le plus grand sprinteur de tous les temps?";
            game2[8].Options = "(a) Yohann Blake\n" +
                "(b) Usain Bolt\n" +
                "(c) pour Noah Lyles";
            game2[8].Answer = 'b';

            game2[9].Question = "Combien de championnat Michael Jordan a-t-il dans sa carrière dans la NBA?";
            game2[9].Options = "(a) 6 championnats\n" +
                "(b) 7 championnats\n" +
                "(c) aucune de ces réponses";
            game2[9].Answer = 'a';
        }
        static void Game3()
        {  //definition d'un objet de Game1
            //Game1:Animaux obj1, obj2, obj3;
            game3[0].Question = "Quelle est le nom de l'animal qui peut rivaliser avec le lion?";
            game3[0].Options = " (a) Gazelle\n" +
                "(b) Hipopotame \n" +
                "(c) Guêpard";

            game3[0].Answer = 'b';              // obj1.affichage();

            game3[1].Question = "Vrai ou Faux: Une autruche entre sa tête dans le sable?";
            game3[1].Options = "Entrez 1 pour Vrai\n" +
                "Entrez 2 pour Faux\n";

            game3[1].Answer = '1';              // obj1.affichage();

            game3[2].Question = "Quelles sont les couleurs du perroquet?";
            game3[2].Options = " (a) Rouge, Mauve et Vert foncé\n" +
                " (b) Noire,Vert et Rouge\n" +
                " (c) Aucune reponse";

            game3[2].Answer = 'b';

            game3[3].Question = "Quel est l'animal le plus rapide du monde?";
            game3[3].Options = "(a) Guépard\n" +
                "(b) dauphin\n" +
                "(c) faucon pélerin";

            game3[3].Answer = 'c';

            game3[4].Question = "Laquel entre ces espèce n'est pas un reptile?";
            game3[4].Options = "(a) salamandre\n" +
                "(b) vipère\n" +
                "(c) caméléon";

            game3[4].Answer = 'a';


            game3[5].Question = "Vrai ou Faux? Le Soleil n'est pas affecté par la gravité";
            game3[5].Options = "Entrez 1 pour Vaut\n" +
                "Entrez 2 pour Faux \n" +
                "Entrez 3 pour Vrai";
            game3[5].Answer = '2';

            game3[6].Question = "Quel est la plus grosse planète dans notre système solaire?";
            game3[6].Options = "(a) Jupiter \n" +
                "(b) Soleil \n" +
                "(c) Saturne";
            game3[6].Answer = 'a';

            game3[7].Question = "Quel scientifique américain est considéré comme " +
                "« l’inventeur » de l’électricité pour son ampoule?";
            game3[7].Options = "(a) Thomas Edison\n" +
                "(b) Alessandro Volta \n" +
                "(c) Bejamin Franklin";
            game3[7].Answer = 'a';
            game3[8].Question = "Lord of the Rings:Quel est le nom du fameux archer elfe?";
            game3[8].Options = "(a) Leonis\n" +
                "(b) Agnadir\n" +
                "(c) Legolas";
            game3[8].Answer = 'c';

            game3[9].Question = "Lord of the Rings: Quel est le nom du premier détenteur du seigneur des anneaux?";
            game3[9].Options = "(a) Saroman \n" +
                "(b) Smiagol \n" +
                "(c) Sauron";
            game3[9].Answer = 'c';
        }
    }
}
