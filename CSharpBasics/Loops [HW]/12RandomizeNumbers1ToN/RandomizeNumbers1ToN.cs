using System;
using System.Linq;

//Write a program that enters in integer n and prints the numbers 
//1, 2, …, n in random order. Examples:

//n	    randomized numbers 1…n
//3	    2 1 3
//10	3 4 8 2 6 7 9 1 10 5 

//Note that the above output is just an example. Due to randomness, 
//your program most probably will produce different results. You 
//might need to use arrays.

class RandomizeNumbers1ToN
{
    static void Main(string[] args)
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = i + 1;
        }

        Random num = new Random();
        int randomNumber = 0;
        int randomIndex = 0;
        for (int i = 1; i <= n; i++)
        {
            randomIndex = num.Next(0, (n - i) + 1);
            randomNumber = array[randomIndex];
            Console.WriteLine("{0}", randomNumber);
            array = array.Where(val => val != randomNumber).ToArray();
        }
    }
}
