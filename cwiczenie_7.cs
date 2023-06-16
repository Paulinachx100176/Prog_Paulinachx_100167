using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Pary liczb naturalnych o sumie {n}:");

        for (int i = 1; i < n; i++)
        {
            int complement = n - i;
            Console.WriteLine(i + " + " + complement + " = " + n);
        }

        Console.ReadLine();
    }
}