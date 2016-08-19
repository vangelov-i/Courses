namespace GeneratePermutationsIteratively
{
    using System;
    using System.Linq;

    public static class GeneratePermutationsIteratively
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbersToPermute = Enumerable.Range(1, n).ToArray();
            int[] permutation = Enumerable.Range(0, numbersToPermute.Length + 1).ToArray();

            Console.WriteLine(string.Join(", ", numbersToPermute));

            int permutationsCount = 1;
            int index = 1;

            while (index < numbersToPermute.Length)
            {
                permutation[index]--;

                int j = 0;
                if (index % 2 == 1)
                {
                    j = permutation[index];
                }

                SwapInts(ref numbersToPermute[index], ref numbersToPermute[j]);
                index = 1;
                while (permutation[index] == 0)
                {
                    permutation[index] = index;
                    index++;
                }

                permutationsCount++;
                Console.WriteLine(string.Join(", ", numbersToPermute));
            }

            Console.WriteLine("Total permutations: {0}", permutationsCount);
        }

        private static void SwapInts(ref int a, ref int b)
        {
            int old = a;
            a = b;
            b = old;
        }
    }
}