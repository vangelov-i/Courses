using System;
using System.Linq;

class GenerateCombinationsIteratively
{
    private static int[] combination;

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int[] numbers = Enumerable.Range(1, n).ToArray();
        combination = Enumerable.Range(1, k).ToArray();

        string[] objects = { "test", "rock", "fun" };

        while (true)
        {
            //Console.WriteLine(string.Join(", ", combination.Select(i => objects[i - 1])));
            Console.WriteLine(string.Join(" ", combination));

            int index = combination.Length - 1;
            combination[index]++;

            while (combination[index] > n - (combination.Length - 1 - index))
            {
                while (index >= 0 && combination[index] >= n - (combination.Length - 1 - index))
                {
                    index--;
                }

                if (index < 0)
                {
                    return;
                }

                combination[index]++;
            }

            for (int i = index + 1; i < combination.Length; i++)
            {
                combination[i] = combination[i - 1] + 1;
            }
        }
    }
}