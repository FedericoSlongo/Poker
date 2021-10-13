
using System;

namespace Lab_Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            int punteggio_1, punteggio_2, a = 0, b = 0;
            string seme_1, seme_2;
            Console.Write("Inserisci il punteggio tuo ");
            punteggio_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserire il punteggio dell'altra persona ");
            punteggio_2 = Convert.ToInt32(Console.ReadLine());

            if (punteggio_1 < punteggio_2)
            {
                Console.WriteLine("L'altra persona ha vinto! (con il punteggio)");
            }
            else if (punteggio_1 > punteggio_2)
            {
                Console.WriteLine("Hai vinto! (con il punteggio)");
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
        }
    }
}
