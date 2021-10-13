using System;

namespace Lab_Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            int punteggio_1, punteggio_2, a, b;
            string seme_1, seme_2;
            Console.Write("Inserisci il punteggio tuo ");
            punteggio_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserire il punteggio dell'altra persona ");
            punteggio_2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserire il seme tuo ");
            seme_1 = Console.ReadLine();
            Console.Write("Inserire il seme dell'altro ");
            seme_2 = Console.ReadLine();

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
                Console.WriteLine("Siete pari :/ (con il punteggio)");
            }

            if (seme_1 == "cuori")
            {
                a = 4;
            }
            else if (seme_1 == "quadri")
            {
                a = 3;
            }
            else if (seme_1 == "fiori")
            {
                a = 2;
            }
            else if (seme_1 == "picche")
            {
                a = 1;
            }

            if (seme_2 == "cuori")
            {
                b = 4;
            }
            else if (seme_2 == "quadri")
            {
                b = 3;
            }
            else if (seme_2 == "fiori")
            {
                b = 2;
            }
            else if (seme_2 == "picche")
            {
                b = 1;
            }


            if (seme_1 == seme_2)
            {
                Console.WriteLine("Siete pari :/ (con il seme)");
            }
            else if ()
            {

            }
        }
    }
}
