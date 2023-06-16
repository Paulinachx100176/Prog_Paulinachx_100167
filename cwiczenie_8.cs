using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wybierz liczbę z przedziału 1-20.");
        Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
        Console.ReadKey();
        Console.Clear();

        int min = 1;
        int max = 20;

        while (true)
        {
            int guess = (min + max) / 2;
            Console.WriteLine("Czy Twoja liczba to {0}? (tak/nie)", guess);

            string answer = Console.ReadLine().ToLower();

            if (answer == "tak")
            {
                Console.WriteLine("Odgadłam Twoją liczbę.");
                break;
            }

            if (answer == "nie")
            {
                Console.WriteLine("Czy Twoja liczba jest większa czy mniejsza? (większa/mniejsza)");
                answer = Console.ReadLine().ToLower();

                if (answer == "większa")
                    min = guess + 1;
                else if (answer == "mniejsza")
                    max = guess - 1;
                else
                    Console.WriteLine("Nieprawidłowa odpowiedź. Spróbuj jeszcze raz.");
            }
            else
            {
                Console.WriteLine("Nieprawidłowa odpowiedź. Spróbuj jeszcze raz.");
            }

            Console.WriteLine();
        }
    }
}
