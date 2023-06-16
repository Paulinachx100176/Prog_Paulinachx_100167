using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj dwie liczby naturalne większe lub równe 5:");

        int n = ReadNumberFromUser();
        int k = ReadNumberFromUser();

        while (n < 5 || k < 5)
        {
            Console.WriteLine("Podane liczby muszą być większe lub równe 5. Spróbuj ponownie.");
            n = ReadNumberFromUser();
            k = ReadNumberFromUser();
        }

        double m = CalculateM(n, k);

        Console.WriteLine($"Wynik: m = {m}");
    }

    static int ReadNumberFromUser()
    {
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Podaj poprawną liczbę!");
        }
        return number;
    }

    static double CalculateM(int n, int k)
    {
        double factorialN = CalculateFactorial(n);
        double factorialK = CalculateFactorial(k);

        double result = (factorialN - factorialK) / factorialK;

        return result;
    }

    static double CalculateFactorial(int number)
    {
        double factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}