using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj kwotę początkową: ");
        float kwota = float.Parse(Console.ReadLine());

        Console.WriteLine("Podaj oprocentowanie w skali roku: ");
        float oprocentowanie = float.Parse(Console.ReadLine());

        Console.WriteLine("Podaj liczbę miesięcy oszczędzania: ");
        int liczbaMiesiecy = int.Parse(Console.ReadLine());

        float podatekBelki = 0.81f; // Zakładamy podatek Belki na poziomie 19%

        float kwotaZarobiona = kwota * (1 + oprocentowanie / 100 / 12) * liczbaMiesiecy * podatekBelki;

        Console.WriteLine("Twoja zarobiona kwota wynosi: " + kwotaZarobiona);

        Console.ReadLine();
    }
}
