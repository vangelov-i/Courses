namespace Permutations
{
    using System;
    using System.Linq;

    class Permutations
    {
        private static int permutationsCount;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] elements = Enumerable.Range(1, n).ToArray();

            GeneratePermutations(elements);
            Console.WriteLine("Total permutations: " + permutationsCount);
        }

        private static void GeneratePermutations(int[] elements, int index = 0)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(", ", elements));
                permutationsCount++;
                return;
            }

            GeneratePermutations(elements, index + 1);
            for (int i = index + 1; i < elements.Length; i++)
            {
                Swap(elements, index, i);
                GeneratePermutations(elements, index + 1);
                Swap(elements, index, i);
            }
        }

        private static void Swap(int[] elements, int index, int i)
        {
            int old = elements[index];
            elements[index] = elements[i];
            elements[i] = old;
        }
    }
}