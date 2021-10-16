using System;

namespace Lab_Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            int punteggio_1 = 0, punteggio_2 = 0, a = 0, b = 0;
            string punteggio1, punteggio2, seme_1, seme_2, language;

            Console.Write("What language would you let the app to run (Italian and English 'work') ");
            language = Console.ReadLine();

            switch (language)
            {
                case "itaian":
                case "Italian":
                case "it":
                case "It":
                    Console.Write("Inserisci il punteggio tuo ");
                    punteggio1 = Console.ReadLine();
                    Console.Write("Inserire il punteggio dell'altra persona ");
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
                            Console.WriteLine("Il tuo punteggio non è valido");
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
                            Console.WriteLine("Il punteggio dell'avversario non è valido");
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
                case "English":
                case "english":
                case "en":
                case "En":
                    Console.WriteLine("This programm will be translated in a bit");
                    break;

                default:
                    Console.WriteLine($"{language} isn't a language allowed");
                    break;
            }
        }
    }
}
