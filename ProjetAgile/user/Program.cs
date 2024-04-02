using ProjetAgile.bus;
using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;
using System.Threading;

namespace ProjetAgile.user
{
    internal class Program
    {
        static Game[] game1 = new Game[10];
        static Game[] game2 = new Game[10];
        static Game[] game3 = new Game[10];

        static byte counter1 = 0;

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
                Console.ForegroundColor = ConsoleColor.DarkYellow;
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
                Console.Clear();

                switch (option)
                {
                    case 1:
                        char start = ' ';

                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("INSCRIPTION\n");
                        Console.ResetColor();

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

                                do
                                {
                                    Console.Write("Voulez-vous commencer maintenant? (y/n) ");
                                    try
                                    {
                                        start = Convert.ToChar(Console.ReadLine());
                                    }
                                    catch (Exception)
                                    {
                                        // reset
                                    }

                                    switch (start)
                                    {
                                        case 'y':
                                            {
                                                //Games 1-2-3-4 Options of 'y'
                                                int choose;
                                                do
                                                {////Games options
                                                menu2: Console.WriteLine("[1] Game1 ");
                                                    Console.WriteLine("[2] Game2 ");
                                                    Console.WriteLine("[3] Game3 ");
                                                    Console.WriteLine("[4] Game4 ");
                                                    ////////////////////
                                                    try
                                                    {
                                                        choose = Convert.ToInt32(Console.ReadLine());
                                                    }
                                                    catch (Exception ex) { Console.WriteLine(ex.Message); goto menu2; }
                                                    ///////////////////
                                                    switch (choose)
                                                    {
                                                        case 1:
                                                            {
                                                                char ans;
                                                                Game1();
                                                                for (int a = 0; a < game1.Length; a++)
                                                                {
                                                                    Console.WriteLine("\n\n\t" + game1[a].Question);
                                                                    Console.WriteLine("\n" + game1[a].Options);
                                                                err2: Console.Write("\tEntrez votre reponse: ");
                                                                    try
                                                                    {
                                                                        ans = Convert.ToChar(Console.ReadLine());
                                                                        if (game1[a].Answer == ans)
                                                                        {
                                                                            counter1++;
                                                                            Console.WriteLine("Bonne réponse");
                                                                        }

                                                                        else
                                                                        {
                                                                            Console.WriteLine("Mauvaise réponse");
                                                                        }
                                                                    }

                                                                    catch (Exception ex) { Console.WriteLine(ex.Message); goto err2; }

                                                                }

                                                            }
                                                            break;
                                                        case 2:
                                                            {
                                                                char ans;
                                                                Game2();
                                                                for (int a = 0; a < game2.Length; a++)
                                                                {
                                                                    Console.WriteLine("\n\n\t" + game2[a].Question);
                                                                    Console.WriteLine("\n" + game2[a].Options);
                                                                err3: Console.Write("\tEntrez votre reponse: ");
                                                                    try
                                                                    {
                                                                        ans = Convert.ToChar(Console.ReadLine());
                                                                        if (game2[a].Answer == ans)
                                                                        {
                                                                            counter1++;
                                                                            Console.WriteLine("Bonne réponse");
                                                                        }

                                                                        else
                                                                        {
                                                                            Console.WriteLine("Mauvaise réponse");
                                                                        }
                                                                    }

                                                                    catch (Exception ex) { Console.WriteLine(ex.Message); goto err3; }
                                                                }
                                                            }
                                                            break;

                                                        case 3:
                                                            {
                                                                char ans;
                                                                Game3();
                                                                for (int a = 0; a < game3.Length; a++)
                                                                {
                                                                    Console.WriteLine("\n\n\t" + game3[a].Question);
                                                                    Console.WriteLine("\n" + game3[a].Options);
                                                                err4: Console.Write("\tEntrez votre reponse: ");
                                                                    try
                                                                    {
                                                                        ans = Convert.ToChar(Console.ReadLine());
                                                                        if (game2[a].Answer == ans)
                                                                        {
                                                                            counter1++;
                                                                            Console.WriteLine("Bonne réponse");
                                                                        }

                                                                        else
                                                                        {
                                                                            Console.WriteLine("Mauvaise réponse");
                                                                        }
                                                                    }

                                                                    catch (Exception ex) { Console.WriteLine(ex.Message); goto err4; }
                                                                }
                                                            }
                                                            break;
                                                        case 4:
                                                            {

                                                            }
                                                            break;
                                                    }
                                                } while (choose != 0);
                                            }break;

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
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("LEADERBOARD\n");
                        Console.ResetColor();

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
            game1[0].Question = "1. Lequel des matériaux suivants un aimant attire-t-il le plus?";
            game1[0].Options = @"
a) Métal
b) Plastique
c) Bois
d) Aluminium
";
            game1[0].Answer = 'a';

            game1[1].Question = "2. Quel est l'origine du whisky Scotch?";
            game1[1].Options = @"
a) Irlande
b) Wales
c) États-Unis
d) Écosse
";
            game1[1].Answer = 'd';

            game1[2].Question = "3. Aux États-Unis, comment s'adresse-t-on formellement à un juge?";
            game1[2].Options = @"
a) Your holiness
b) Your honor
c) Your eminence
d) Sir/Ma'am
";
            game1[2].Answer = 'b';

            game1[3].Question = "4. Dans lequel de ces films l'Actrice Whoopi Goldberg se déguise-t-elle en soeur?";
            game1[3].Options = @"
a) Ghost
b) Sister Act
c) How Judas got his groove back
d) The color purple
";
            game1[3].Answer = 'b';

            game1[4].Question = "5. Complétez l'expression suivante: \"Be there or be [...]\"";
            game1[4].Options = @"
a) Bare
b) Square
c) Aware
d) Fair
";
            game1[4].Answer = 'b';

            game1[5].Question = "6. Comment appelle-t-on la partie d'un arbre coupé qui reste dans le sol?";
            game1[5].Options = @"
a) Croupe
b) Bosse
c) Souche
d) Reste
";
            game1[5].Answer = 'c';

            game1[6].Question = "7. Une berceuse est une chanson pour les bébés qui aide à faire quoi?";
            game1[6].Options = @"
a) Se réveiller
b) Dormir
c) Manger
d) Apprendre
";
            game1[6].Answer = 'b';

            game1[7].Question = "8. Lequel de ces noms ne se trouve pas dans le titre d'une pièce de Shakespeare?";
            game1[7].Options = @"
a) Hamlet
b) Romeo
c) Macbeth
d) Darren
";
            game1[7].Answer = 'd';

            game1[8].Question = "9. Laquelle de ces expressions signifie \"se retrouver dans une situation risquée\"?";
            game1[8].Options = @"
a) Marcher sur des oeufs
b) Marcher sur de la glace mince
c) Marcher sur la pointe des pieds
d) Marcher sur une corde
";
            game1[8].Answer = 'a';

            game1[9].Question = "10. Quand est la fête des pères?";
            game1[9].Options = @"
a) Le 1er dimanche de juin
b) Le 2e dimanche de juin
c) Le 3e dimanche de juin
d) Le 4e dimanche de juin
";
            game1[9].Answer = 'c';
        }

        static void Game2()
        {
            game2[0].Question = "Vrai ou Faux: Le pH de l'ananas est de 3,71  ";
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

            game2[2].Question = " Quel artiste est considéré comme le roi de la POP?";
            game2[2].Options = 
                " (a) The Weeknd\n" +
                " (b) The Beatles\n" +
                " (c) Prince \n" +
                " (d) Michael Jackson ";
            game2[2].Answer = 'c';

            game2[3].Question = "Vrai ou Faux : Jerry West est le joueur présent sur le logo de la NBA";
            game2[3].Options = 
                " Entrez 1 pour vrai\n" +
                " Entrez 2 pour faux";
            game2[3].Answer = '1';

            game2[4].Question = "Quel est la formule brut du glucose (sucre)?";
            game2[4].Options = 
                " (a) ( C6/H12/O6 )\n" +
                " (b) ( C2/H6/O )\n" +
                " (c) ( N/O3 )\n" +
                " (d) ( C2/H4/O2 )";
            game2[4].Answer = 'a';

            game2[5].Question = "Vrai ou Faux : Le crâne est l'os le plus résistant du corps humain";
            game2[5].Options = "Entrez 1 pour Vrai\n" +
            "Entrez 2 pour Faux\n";
            game2[5].Answer = '2';

            game2[6].Question = "Quel pays ne fait pas parti de l'OTAN ?";
            game2[6].Options = 
                " (a) Slovaquie \n" +
                " (b) Slovénie\n " +
                " (c) Vatican" +
                " (d) Estonie"; 
            game2[6].Answer = 'c';

            game2[7].Question = "Quelle ville est considérée comme sainte pour les trois principales religions abrahamiques ?";
            game2[7].Options = 
                " (a) Nador\n" +
                " (b) Jérusalem\n" +
                " (c) Constantine\n " +
                " (d) Tibériade\n";
            game2[7].Answer = 'b';

            game2[8].Question = "Dans la mythologie grec, quel dieu/déesse est considéré comme le dieu de la guerre ?";
            game2[8].Options = 
                " (a) Hades\n" +
                " (b) Ares\n" +
                " (c) Thanatos\n" +
                " (d) Artémis";
            game2[8].Answer = 'b';

            game2[9].Question = "Combien de championnat Michael Jordan a-t-il dans sa carrière dans la NBA?";
            game2[9].Options = 
                " (a) 6 championnats\n" +
                " (b) 7 championnats\n" +
                " (c) 8 championnats\n"+
                " (d) aucune de ces réponses";
            game2[9].Answer = 'a';
        }
        static void Game3()
        {  
            game3[0].Question = "Quelle est le nom de l'animal qui peut rivaliser avec le lion?";
            game3[0].Options = "Entrez 1 pour Gazelle\n" +
                "Entrez 2 pour Hipopotame \n" +
                "Entrez 3 pour Guêpar";

            game3[0].Answer = '2';              // obj1.affichage();

            game3[1].Question = "Vrai ou Faux: Une autruche entre sa tête dans le sable?";
            game3[1].Options = "Entrez 1 pour Vrai\n" +
                "Entrez 2 pour Faux\n";

            game3[1].Answer = '1';              // obj1.affichage();

            game3[2].Question = "Quelles sont les couleurs du perroquet?";
            game3[2].Options = "Entrez 1 pour Rouge, Mauve et Vert foncé\n" +
                "Entrez 2 pour Noire,Vert et Rouge\n" +
                "Entrez 3 pour Aucune reponse";

            game3[2].Answer = '2';

            game3[3].Question = "Quel est l'animal le plus rapide du monde?";
            game3[3].Options = "Entrez 1 pour Guépare\n" +
                "Entrez 2 pour dauphin\n" +
                "Entrez 3 pour faucon pélerin";

            game3[3].Answer = '3';

            game3[4].Question = "Laquel entre ces espèce n'est pas un reptile?";
            game3[4].Options = "Entrez 1 pour salamandre\n" +
                "Entrez 2 pour vipère\n" +
                "Entrez 3 pour caméléon";

            game3[4].Answer = '1';


            game3[5].Question = "Vrai ou Faux? Le Soleil n'est pas affecté par la gravité";
            game3[5].Options = "Entrez 1 pour Vaut\n" +
                "Entrez 2 pour Faux \n" +
                "Entrez 3 pour Vrai";
            game3[5].Answer = '2';

            game3[6].Question = "Quel est la plus grosse planète dans notre système solaire?";
            game3[6].Options = "Entrez 1 pour Jupiter \n" +
                "Entrez 2 pour Soleil \n" +
                "Entrez 3 pour Saturne";
            game3[6].Answer = '1';

            game3[7].Question = "Quel scientifique américain est considéré comme " +
                "« l’inventeur » de l’électricité pour son ampoule?";
            game3[7].Options = "Entrez 1 pour Thomas Edison\n" +
                "Entrez 2 pour Alessandro Volta \n" +
                "Entrez 3 pour Bejamin Franklin";
            game3[7].Answer = '1';
            game3[8].Question = "Lord of the Rings:Quel est le nom du fameux archer elfe?";
            game3[8].Options = "Entrez 1 pour Leonis\n" +
                "Entrez 2 pour Agnadir\n" +
                "Entrez 3 pour Legolas";
            game3[8].Answer = '3';

            game3[9].Question = "Lord of the Rings: Quel est le nom du premier détenteur du seigneur des anneaux?";
            game3[9].Options = "Entrez 1 pour Saroman \n" +
                "Entrez 2 pour Satan \n" +
                "Entrez 3 pour Sauron";
            game3[9].Answer = '3';
        }
    }
}
