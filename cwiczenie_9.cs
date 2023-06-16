using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę:");
        string input = Console.ReadLine();

        string reversedInput = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversedInput += input[i];
        }

        Console.WriteLine("Liczba po odwróceniu: " + reversedInput);
    }
}

