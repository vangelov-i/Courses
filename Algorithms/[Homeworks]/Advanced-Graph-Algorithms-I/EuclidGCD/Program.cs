using System;

class Program
{
    static void Main()
    {
        int bigger = int.Parse(Console.ReadLine());
        int smaller = int.Parse(Console.ReadLine());

        if (bigger < smaller)
        {
            smaller ^= bigger;
            bigger ^= smaller;
            smaller ^= bigger;
        }

        Console.WriteLine(GetGCD(bigger, smaller));
    }

    private static int GetGCD(int bigger, int smaller)
    {
        while (smaller > 0)
        {
            bigger %= smaller;

            smaller ^= bigger;
            bigger ^= smaller;
            smaller ^= bigger;
        }

        return bigger;
    }
}