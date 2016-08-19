namespace GenerateCombosWithoutRepetition
{
    using System;

    class GenerateCombosWithoutRepetition
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[k];

            GenCombosWithoutRepetition(array, n);
        }

        static void GenCombosWithoutRepetition(int[] array, int n, int index = 0, int start = 1)
        {
            if (index >= array.Length)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            for (int i = start; i <= n; i++)
            {
                array[index] = i;
                GenCombosWithoutRepetition(array, n, index + 1, i +1);
            }
        }
    }
}