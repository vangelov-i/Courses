namespace GenerateCombosWithRepetition
{
    using System;

    class GenerateCombosWithRepetition
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[k];

            GenCombosWithRepetition(array, n);
        }

        static void GenCombosWithRepetition(int[] array, int n, int index = 0, int start = 1)
        {
            if (index >= array.Length)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            for (int i = start; i <= n; i++)
            {
                array[index] = i;
                GenCombosWithRepetition(array, n, index + 1, i);
            }
        }
    }
}