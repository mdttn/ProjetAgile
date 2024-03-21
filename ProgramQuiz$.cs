using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetQuiz_
{
    internal class Program
    {
        // Creation de tableaux
        static Quiz1[] arrQuiz1 = new Quiz1[10];
        static Quiz2[] arrQuiz2 = new Quiz2[10];
        static Quiz3[] arrQuiz3 = new Quiz3[10];
        static int counter1 = 0, counter2 = 0, counter3 = 0;
        static void Main(string[] args)
        {
            int option = 0;
            do
            {//menu principal
            err1: Console.WriteLine("Entrez 1 pour Quiz1:Animaux");
                Console.WriteLine("Entrez 2 pour Quiz2:Science");
                Console.WriteLine("Entrez 3 pour Quiz3:Film Super-Héros");
                Console.WriteLine("Entrez 0 pour Quitter");
                Console.Write("Votre option: ");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            {
                                char ans = ' ';
                                Iverson1();//Appel a la methode pour batir le tableau
                                for (int i = 0; i < arrQuiz1.Length; i++)
                                {
                                    Console.WriteLine("\n\n\t" + arrQuiz1[i].question);
                                    Console.WriteLine("\n" + arrQuiz1[i].reponses);
                                err2: Console.Write("\tEntrez votre reponse: ");
                                    try
                                    {
                                        ans = Convert.ToChar(Console.ReadLine());
                                        if (arrQuiz1[i].bonneReponse == ans)
                                        {
                                            counter1++;
                                            Console.ForegroundColor = ConsoleColor.Green;//change de couleur
                                            Console.WriteLine("\t\tBonne reponse");
                                            Console.ForegroundColor = ConsoleColor.White;//couleur à l'origine
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;//change de couleur
                                            Console.WriteLine("\t\tMauvais reponse");
                                            Console.ForegroundColor = ConsoleColor.White;//couleur à l'origine
                                        }
                                    }
                                    catch (Exception ex) { Console.WriteLine(ex.Message); goto err2; }
                                }
                                Console.WriteLine($"\n\tPour {arrQuiz1.Length} questions" +
                                    $" vous avez {counter1} bonne reponses");
                            }//fin case 1
                            break;
                        case 2:
                            {
                                char ans = ' ';
                                Abdoulai2();//Appel a la methode pour batir le tableau
                                for (int i = 0; i < arrQuiz2.Length; i++)
                                {
                                    Console.WriteLine("\n\n\t" + arrQuiz2[i].question);
                                    Console.WriteLine("\n" + arrQuiz2[i].reponses);
                                err2: Console.Write("\tEntrez votre reponse: ");
                                    try
                                    {
                                        ans = Convert.ToChar(Console.ReadLine());
                                        if (arrQuiz2[i].bonneReponse == ans)
                                        {
                                            counter2++;
                                            Console.ForegroundColor = ConsoleColor.Green;//change de couleur
                                            Console.WriteLine("\t\tBonne reponse");
                                            Console.ForegroundColor = ConsoleColor.White;//couleur à l'origine
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;//change de couleur
                                            Console.WriteLine("\t\tMauvais reponse");
                                            Console.ForegroundColor = ConsoleColor.White;//couleur à l'origine
                                        }
                                    }
                                    catch (Exception ex) { Console.WriteLine(ex.Message); goto err2; }
                                }
                                Console.WriteLine($"\n\tPour {arrQuiz2.Length} questions" +
                                    $" vous avez {counter2} bonne reponses");
                            }
                            break;
                        case 3:
                            {
                                char ans = ' ';
                                Therese3();//Appel a la methode pour batir le tableau
                                for (int i = 0; i < arrQuiz3.Length; i++)
                                {
                                    Console.WriteLine("\n\n\t" + arrQuiz3[i].question);
                                    Console.WriteLine("\n" + arrQuiz3[i].reponses);
                                err2: Console.Write("\tEntrez votre reponse: ");
                                    try
                                    {
                                        ans = Convert.ToChar(Console.ReadLine());
                                        if (arrQuiz3[i].bonneReponse == ans)
                                        {
                                            counter3++;
                                            Console.ForegroundColor = ConsoleColor.Green;//change de couleur
                                            Console.WriteLine("\t\tBonne reponse");
                                            Console.ForegroundColor = ConsoleColor.White;//couleur à l'origine
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;//change de couleur
                                            Console.WriteLine("\t\tMauvais reponse");
                                            Console.ForegroundColor = ConsoleColor.White;//couleur à l'origine
                                        }
                                    }
                                    catch (Exception ex) { Console.WriteLine(ex.Message); goto err2; }
                                }
                                Console.WriteLine($"\n\tPour {arrQuiz3.Length} questions" +
                                    $" vous avez {counter3} bonne reponses");
                            }
                            break;
                        case 0: { } break;
                        default: { } break;
                    }
                }//fin try
                catch (Exception ex) { Console.WriteLine(ex.Message); goto err1; }
            } while (option != 0);

            Console.ReadKey();
        }//fin Main()

        static void Iverson1()
        {  //definition d'un objet de Game1
            //Game1:Animaux obj1, obj2, obj3;
            arrQuiz1[0].question = "Quelle est le nom de l'animal qui peut rivaliser avec le lion?";
            arrQuiz1[0].reponses = "Entrez 1 pour Gazelle\n" +
                "Entrez 2 pour Hipopotame \n" +
                "Entrez 3 pour Guêpar";

            arrQuiz1[0].bonneReponse = '2';              // obj1.affichage();

            arrQuiz1[1].question = "Vrai ou Faux: Une autruche entre sa tête dans le sable?";
            arrQuiz1[1].reponses = "Entrez 1 pour Vrai\n" +
                "Entrez 2 pour Faux\n";

            arrQuiz1[1].bonneReponse = '1';              // obj1.affichage();

            arrQuiz1[2].question = "Quelles sont les couleurs du perroquet?";
            arrQuiz1[2].reponses = "Entrez 1 pour Rouge, Mauve et Vert foncé\n" +
                "Entrez 2 pour Noire,Vert et Rouge\n" +
                "Entrez 3 pour Aucune reponse";

            arrQuiz1[2].bonneReponse = '2';

            arrQuiz1[3].question = "Quel est l'animal le plus rapide du monde?";
            arrQuiz1[3].reponses = "Entrez 1 pour Guépare\n" +
                "Entrez 2 pour dauphin\n" +
                "Entrez 3 pour faucon pélerin";

            arrQuiz1[3].bonneReponse = '3';

            arrQuiz1[4].question = "Laquel entre ces espèce n'est pas un reptile?";
            arrQuiz1[4].reponses = "Entrez 1 pour salamandre\n" +
                "Entrez 2 pour vipère\n" +
                "Entrez 3 pour caméléon";

            arrQuiz1[4].bonneReponse = '1';


            arrQuiz1[5].question = "Vrai ou Faux? Le Soleil n'est pas affecté par la gravité";
            arrQuiz1[5].reponses = "Entrez 1 pour Vaut\n" +
                "Entrez 2 pour Faux \n" +
                "Entrez 3 pour Vrai";
            arrQuiz1[5].bonneReponse = '2';

            arrQuiz1[6].question = "Quel est la plus grosse planète dans notre système solaire?";
            arrQuiz1[6].reponses = "Entrez 1 pour Jupiter \n" +
                "Entrez 2 pour Soleil \n" +
                "Entrez 3 pour Saturne";
            arrQuiz1[6].bonneReponse = '1';

            arrQuiz1[7].question = "Quel scientifique américain est considéré comme " +
                "« l’inventeur » de l’électricité pour son ampoule?";
            arrQuiz1[7].reponses = "Entrez 1 pour Thomas Edison\n" +
                "Entrez 2 pour Alessandro Volta \n" +
                "Entrez 3 pour Bejamin Franklin";
            arrQuiz1[7].bonneReponse = '1';
            arrQuiz1[8].question = "Lord of the Rings:Quel est le nom du fameux archer elfe?";
            arrQuiz1[8].reponses = "Entrez 1 pour Leonis\n" +
                "Entrez 2 pour Agnadir\n" +
                "Entrez 3 pour Legolas";
            arrQuiz1[8].bonneReponse = '3';

            arrQuiz1[9].question = "Lord of the Rings: Quel est le nom du premier détenteur du seigneur des anneaux?";
            arrQuiz1[9].reponses = "Entrez 1 pour Saroman \n" +
                "Entrez 2 pour Satan \n" +
                "Entrez 3 pour Sauron";
            arrQuiz1[9].bonneReponse = '3';
        }
        static void Abdoulai2() 
        { }
        static void Therese3() 
        { }
                    }
    }
