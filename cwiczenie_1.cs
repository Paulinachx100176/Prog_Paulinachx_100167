using System;

namespace Cwiczenie_1_cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj podstawę:");
            int podstawa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj wykładnik:");
            int wykladnik = Convert.ToInt32(Console.ReadLine());

            int wynik = Potegowanie(podstawa, wykladnik);
            Console.WriteLine("Wynik potęgowania: " + wynik);

            Console.ReadLine();
        }

        static int Potegowanie(int podstawa, int wykladnik)
        {
            if (wykladnik == 0)
                return 1;

            return podstawa * Potegowanie(podstawa, wykladnik - 1);
        }
    }
}
