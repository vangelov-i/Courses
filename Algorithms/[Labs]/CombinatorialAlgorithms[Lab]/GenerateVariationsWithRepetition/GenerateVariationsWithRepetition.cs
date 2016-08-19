namespace GenerateVariationsWithRepetition
{
    using System;

    class GenerateVariationsWithRepetition
    {
        static void Main()
        {
            
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k];

            GenerateVariationsWithRep(arr, n);
        }

        static void GenerateVariationsWithRep(int[] arr, int n, int index = 0)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                arr[index] = i;
                GenerateVariationsWithRep(arr, n, index + 1);
            }
        }
    }
}