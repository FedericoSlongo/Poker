using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            int punteggio_1 = 0, punteggio_2 = 0, a = 0, b = 0;
            string punteggio1, punteggio2, seme_1, seme_2, language;
            bool error=false;

            do
            {
                Console.Write("What language would you let the app to run (Italian and English 'work') ");
                language = Console.ReadLine().ToLower();
            } while (!(language == "it" || language == "italian" || language == "english" || language == "en"));

            switch (language)
            {
                case "italian":
                case "it":
                    Console.Write("Inserisci il punteggio tuo ");
                    punteggio1 = Console.ReadLine();

                    switch (punteggio1)
                    {
                        case "1":
                        case "2":
                        case "3":
                        case "4":
                        case "5":
                        case "6":
                        case "7":
                        case "8":
                        case "9":
                            punteggio_1 = Convert.ToInt32(punteggio1);
                            break;
                        case "Jack":
                        case "jack":
                            punteggio_1 = 10;
                            break;
                        case "Queen":
                        case "queen":
                            punteggio_1 = 11;
                            break;
                        case "King":
                        case "king":
                            punteggio_1 = 12;
                            break;
                        default:
                            Console.WriteLine("Il tuo punteggio non è valido");
                            error = true;
                            break;
                    }

                    if (error)
                    {
                        break;
                    }

                    Console.Write("Inserire il punteggio dell'altra persona ");
                    punteggio2 = Console.ReadLine();

                    switch (punteggio2)
                    {
                        case "1":
                        case "2":
                        case "3":
                        case "4":
                        case "5":
                        case "6":
                        case "7":
                        case "8":
                        case "9":
                            punteggio_2 = Convert.ToInt32(punteggio2);
                            break;
                        case "Jack":
                        case "jack":
                            punteggio_2 = 10;
                            break;
                        case "Queen":
                        case "queen":
                            punteggio_2 = 11;
                            break;
                        case "King":
                        case "king":
                            punteggio_2 = 12;
                            break;
                        default:
                            Console.WriteLine("Il punteggio dell'avversario non è valido");
                            error = true;
                            break;
                    }

                    if (error)
                    {
                        break;
                    }

                    if (punteggio_1 < punteggio_2)
                    {
                        Console.WriteLine("L'altra persona ha vinto!");
                    }
                    else if (punteggio_1 > punteggio_2)
                    {
                        Console.WriteLine("Hai vinto!");
                    }
                    else if (punteggio_1 == punteggio_2)
                    {
                        Console.Write("Inserire il seme tuo ");
                        seme_1 = Console.ReadLine();
                        Console.Write("Inserire il seme dell'altro ");
                        seme_2 = Console.ReadLine();

                        switch (seme_1)
                        {
                            case "cuori":
                                a = 4;
                                break;
                            case "quadri":
                                a = 3;
                                break;
                            case "fiori":
                                a = 2;
                                break;
                            case "picche":
                                a = 1;
                                break;
                            default:
                                Console.WriteLine("Non hai inserito una parola valida!");
                                break;
                        }

                        switch (seme_2)
                        {
                            case "cuori":
                                b = 4;
                                break;
                            case "quadri":
                                b = 3;
                                break;
                            case "fiori":
                                b = 2;
                                break;
                            case "picche":
                                b = 1;
                                break;
                            default:
                                Console.WriteLine("Non hai inserito una parola valida!");
                                break;
                        }

                        if (a == b)
                        {
                            Console.WriteLine("Siete pari :/");
                        }
                        else if (a > b)
                        {
                            Console.WriteLine("Tu hai vinto");
                        }
                        else if (a < b)
                        {
                            Console.WriteLine("L'altra persona a vinto");
                        }
                    }
                    break;
                case "english":
                case "en":
                    Console.Write("Enter your score ");
                    punteggio1 = Console.ReadLine();
                    Console.Write("Enter the score of the other person ");
                    punteggio2 = Console.ReadLine();

                    switch (punteggio1)
                    {
                        case "1":
                        case "2":
                        case "3":
                        case "4":
                        case "5":
                        case "6":
                        case "7":
                        case "8":
                        case "9":
                            punteggio_1 = Convert.ToInt32(punteggio1);
                            break;
                        case "Jack":
                        case "jack":
                            punteggio_1 = 10;
                            break;
                        case "Queen":
                        case "queen":
                            punteggio_1 = 11;
                            break;
                        case "King":
                        case "king":
                            punteggio_1 = 12;
                            break;
                        default:
                            Console.WriteLine("You're score isn't valid");
                            break;
                    }

                    switch (punteggio2)
                    {
                        case "1":
                        case "2":
                        case "3":
                        case "4":
                        case "5":
                        case "6":
                        case "7":
                        case "8":
                        case "9":
                            punteggio_2 = Convert.ToInt32(punteggio2);
                            break;
                        case "Jack":
                        case "jack":
                            punteggio_2 = 10;
                            break;
                        case "Queen":
                        case "queen":
                            punteggio_2 = 11;
                            break;
                        case "King":
                        case "king":
                            punteggio_2 = 12;
                            break;
                        default:
                            Console.WriteLine("The other score isn't valid");
                            break;
                    }

                    if (punteggio_1 < punteggio_2)
                    {
                        Console.WriteLine("The other person won!");
                    }
                    else if (punteggio_1 > punteggio_2)
                    {
                        Console.WriteLine("You won!");
                    }
                    else if (punteggio_1 == punteggio_2)
                    {
                        Console.Write("Insert your seed ");
                        seme_1 = Console.ReadLine().ToLower();
                        Console.Write("Insert the other person seed ");
                        seme_2 = Console.ReadLine().ToLower();

                        switch (seme_1)
                        {
                            case "heart":
                            case "Heart":
                                a = 4;
                                break;
                            case "diamonds":
                            case "Diamonds":
                                a = 3;
                                break;
                            case "clubs":
                            case "Clubs":
                                a = 2;
                                break;
                            case "spades":
                            case "Spades":
                                a = 1;
                                break;
                            default:
                                Console.WriteLine("You didn't insert a valid seed!");
                                break;
                        }

                        switch (seme_2)
                        {
                            case "heart":
                            case "Heart":
                                b = 4;
                                break;
                            case "diamonds":
                            case "Diamonds":
                                b = 3;
                                break;
                            case "clubs":
                            case "Clubs":
                                b = 2;
                                break;
                            case "spades":
                            case "Spades":
                                b = 1;
                                break;
                            default:
                                Console.WriteLine("You didn't insert a valid seed");
                                break;
                        }

                        if (a == b)
                        {
                            Console.WriteLine("You're equal :/");
                        }
                        else if (a > b)
                        {
                            Console.WriteLine("You won!");
                        }
                        else if (a < b)
                        {
                            Console.WriteLine("The other person won!");
                        }
                    }
                    break;

                default:
                    Console.WriteLine($"{language} isn't a language allowed");
                    break;
            }
            Console.ReadKey();
        }
    }
}
