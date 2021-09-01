using System;
using System.Collections.Generic;

// Tulostetaan raporttina allekain kaikki syötetyt luvut ("L") tai tulostetaan VAIN lukujen summa ("S")
// Valitse raporttityyppi("L" tai "S"):


namespace tehtävä2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tulostetaan raporttina allekain kaikki syötetyt luvut (\"L\") tai tulostetaan VAIN lukujen summa (\"S\")");
            Console.WriteLine("Valitse raporttityyppi(\"L\" tai \"S\"):");
            string vastaus = Console.ReadLine();
            while(vastaus.ToLower() != "l" && vastaus.ToLower() != "s")
            { 
                Console.WriteLine($"{vastaus} raporttityyppiä ei ole.");
                Console.WriteLine("Valitse raporttityyppi(\"L\" tai \"S\"):");
                vastaus = Console.ReadLine();
            }
            Console.WriteLine("Syötä kokonaisluku lisättäväksi listaan tai \"K\" keskeytä");
            string luku = Console.ReadLine();
            int iluku;
            int summa = 0;
            List<int> lista = new List<int>();
            
            while (luku.ToLower() != "k")
            {
                if (int.TryParse(luku, out iluku))
                {
                    summa += iluku;
                    lista.Add(iluku);

                }
                else
                {
                    Console.WriteLine("Vain kokonaislukuja tai k");
                }
                Console.WriteLine("Syötä kokonaisluku lisättäväksi listaan tai \"K\" keskeytä");
                luku = Console.ReadLine();
            }
            if(vastaus.ToLower() == "s")
            {
                Console.WriteLine("Syötettyjen lukujen summa:");
                Console.WriteLine(summa);
            }
            else
            {
                Console.WriteLine("Syötetyt luvut:");
                foreach(int element in lista)
                {
                    Console.WriteLine($"{ element}");
                }
                Console.WriteLine("Syötettyjen lukujen summa:");
                Console.WriteLine(summa);
            }
        }
    }
}

