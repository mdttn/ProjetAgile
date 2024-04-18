using ProjetAgile.bus;
using System;
using System.CodeDom;
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

        static void Main(string[] args)
        {
            List<Player> playerList = new List<Player>();
            Player player;
            int i = 0;
            int option;
            int counter;

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
                            Console.Write("Votre nom: ");
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
                                            char ans;
                                            bool done = false;

                                            Console.Clear();
                                            Game1();
                                            counter = 0;
                                            do
                                            {
                                                for (int g = 0; g < game1.Length; g++)
                                                {
                                                    Console.WriteLine(game1[g].Question);
                                                    Console.WriteLine(game1[g].Options);
                                                label2:
                                                    Console.Write("=> ");
                                                    try
                                                    {
                                                        ans = Convert.ToChar(Console.ReadLine());
                                                        if (game1[g].Answer == ans)
                                                        {
                                                            counter++;
                                                            player.Money += 10 * (g + 1);
                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("\nBonne réponse.\n");
                                                            Console.ResetColor();
                                                            Console.WriteLine(player.Money + "\n");
                                                            if (counter == 10)
                                                            {
                                                                done = true;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("\nMauvaise réponse.\n");
                                                            Console.ResetColor();
                                                            done = true;
                                                        }
                                                    }
                                                    catch (Exception)
                                                    {
                                                        goto label2;
                                                    }
                                                }
                                            }
                                            while (!done);

                                            if (done)
                                            {
                                                Console.WriteLine(player.GetResult());
                                                Console.ReadLine();
                                                Console.Clear();
                                                if (counter == 10)
                                                {
                                                    char next = ' ';

                                                    do
                                                    {
                                                        Console.WriteLine("Voulez-vous passer à la prochaine série de questions? (y/n)");
                                                        Console.WriteLine("* Si oui, vous pouvez gagner plus d'argent, mais vous risquez aussi de tout perdre.");
                                                        Console.WriteLine("* Sinon, vous gardez votre montant actuel et vous ne pouvez plus rejouer.");
                                                        Console.Write("=> ");
                                                        try
                                                        {
                                                            next = Convert.ToChar(Console.ReadLine());
                                                        }
                                                        catch (Exception)
                                                        {
                                                            // reset
                                                        }

                                                        switch (next)
                                                        {
                                                            case 'y':
                                                                Console.Clear();
                                                                Game2();
                                                                counter = 0;
                                                                done = false;
                                                                do
                                                                {
                                                                    for (int g = 0; g < game2.Length; g++)
                                                                    {
                                                                        Console.WriteLine(game2[g].Question);
                                                                        Console.WriteLine(game2[g].Options);
                                                                    label3:
                                                                        Console.Write("=> ");
                                                                        try
                                                                        {
                                                                            ans = Convert.ToChar(Console.ReadLine());
                                                                            if (game2[g].Answer == ans)
                                                                            {
                                                                                counter++;
                                                                                player.Money += 10 * (g + 1);
                                                                                Console.ForegroundColor = ConsoleColor.Green;
                                                                                Console.WriteLine("\nBonne réponse.\n");
                                                                                Console.ResetColor();
                                                                                Console.WriteLine(player.Money + "\n");
                                                                                if (counter == 10)
                                                                                {
                                                                                    done = true;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("\nMauvaise réponse.\n");
                                                                                Console.ResetColor();
                                                                                done = true;
                                                                            }
                                                                        }
                                                                        catch (Exception)
                                                                        {
                                                                            goto label3;
                                                                        }
                                                                    }
                                                                }
                                                                while (!done);
                                                                break;
                                                            case 'n':
                                                                // leave
                                                                break;
                                                            default:
                                                                // reset
                                                                break;
                                                        }
                                                    }
                                                    while (next != 'n');                                                    
                                                }
                                            }
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
                            goto label1;
                        }
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("LEADERBOARD\n");
                        Console.ResetColor();

                        playerList.Reverse();

                        foreach (Player p in playerList)
                        {
                            Console.WriteLine($"{p.GetResult()}");
                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nCliquez 2 fois pour quitter.");
                        Console.ResetColor();
                        break;
                    default:
                        // reset
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
            game2[0].Question = "1. Quel animal peut rivaliser avec le lion?";
            game2[0].Options = @"
a) Gazelle
b) Hippopotame
c) Guépard
d) Léopard
";

            game2[0].Answer = 'b';

            game2[1].Question = "2. Vrai ou Faux?\nUne autruche peut entrer sa tête dans le sable.";
            game2[1].Options = @"
a) Vrai
b) Faux
";

            game2[1].Answer = 'a';

            game2[2].Question = "3. Quelles sont les couleurs fréquemment retrouvées sur le plumage d'un perroquet?";
            game2[2].Options = @"
a) Rouge, mauve et vert foncé
b) Bleu, vert et rouge
c) Noir, bleu et orange
d) Turquoise, blanc et rose
";
            game2[2].Answer = 'b';

            game2[3].Question = "4. Quel est l'animal le plus rapide au monde?";
            game2[3].Options = @"
a) Guépard
b) Espadon-voilier
c) Faucon pèlerin
d) Tigre
";
            game2[3].Answer = 'c';

            game2[4].Question = "5. Laquelle de ces espèces n'est pas un reptile?";
            game2[4].Options = @"
a) Salamandre
b) Vipère
c) Caméléon
d) Tortue
";
            game2[4].Answer = 'a';


            game2[5].Question = "6. Vrai ou Faux?\nLe Soleil n'est pas affecté par la gravité.";
            game2[5].Options = @"
a) Vrai
b) Faux
";
            game2[5].Answer = 'b';

            game2[6].Question = "7. Quelle est la plus grosse planète dans notre système solaire?";
            game2[6].Options = @"
a) Pluton
b) Saturne
c) Vénus
d) Jupiter
";
            game2[6].Answer = 'd';

            game2[7].Question = "8. Quel scientifique américain est considéré \"l’inventeur\" de l’électricité pour son ampoule?";
            game2[7].Options = @"
a) Alessandro Volta
b) Thomas Edison
c) Benjamin Franklin
d) James Watt
";
            game2[7].Answer = 'b';

            game2[8].Question = "9. Comment s'appelle le fameux archer elfe dans \"Lord of the Rings\"?";
            game2[8].Options = @"
a) Leonis
b) Agnadir
c) Legolas
d) Gandalf
";
            game2[8].Answer = 'c';

            game2[9].Question = "10. Quelle constellation ressemble à une lettre de l'alphabet?";
            game2[9].Options = @"
a) Andromède
b) Grande Ourse
c) Orion
d) Cassiopée
";
            game2[9].Answer = 'd';
        }

        static void Game3()
        {
            game3[0].Question = "1. Vrai ou Faux?\nLe pH de l'ananas est de 3,71.";
            game3[0].Options = @"
a) Vrai
b) Faux
";
            game3[0].Answer = 'a';
            

            game3[1].Question = "2. Combien d'étoiles sont présentes sur le drapeau des États-Unis?";
            game3[1].Options = @"
a) 48
b) 50
c) 51
d) 52
";
            game3[1].Answer = 'b';

            game3[2].Question = "3. Quel artiste est considéré comme le roi du genre pop?";
            game3[2].Options = @"
a) The Weeknd
b) The Beatles
c) Prince
d) Michael Jackson
";
            game3[2].Answer = 'c';

            game3[3].Question = "4. Vrai ou Faux?\nJerry West est le joueur présent sur le logo de la NBA.";
            game3[3].Options = @"
a) Vrai
b) Faux
";
            game3[3].Answer = 'a';

            game3[4].Question = "5. Quel est la formule brut du glucose (sucre)?";
            game3[4].Options = @"
a) C6H12O6
b) C2H6O
c) NO3
d) C2H4O2
";
            game3[4].Answer = 'a';

            game3[5].Question = "6. Vrai ou Faux?\nLe crâne est l'os le plus résistant du corps humain.";
            game3[5].Options = @"
a) Vrai
b) Faux
";
            game3[5].Answer = 'b';

            game3[6].Question = "7. Quel pays ne fait pas parti de l'OTAN?";
            game3[6].Options = @"
a) Slovaquie
b) Slovénie
c) Vatican
d) Estonie
";
            game3[6].Answer = 'c';

            game3[7].Question = "8. Quelle ville est considérée comme sainte pour les trois principales religions abrahamiques?";
            game3[7].Options = @"
a) Nador
b) Jérusalem
c) Constantine
d) Tibériade
";
            game3[7].Answer = 'b';

            game3[8].Question = "9. Dans la mythologie grecque, quel divinité est considéréé comme le dieu/la déesse de la guerre ?";
            game3[8].Options = @"
a) Hadès
b) Arès
c) Thanatos
d) Artémis
";
            game3[8].Answer = 'b';

            game3[9].Question = "10. Combien de championnats Michael Jordan a-t-il gagnés dans sa carrière dans la NBA?";
            game3[9].Options = @"
a) 6
b) 7
c) 8
d) 9
";
            game3[9].Answer = 'a';
        }
    }
}
