using System;

class CombinationsWithRepetition
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[k];

        GenerateCombos(arr, 0, 1, n);
    }

    private static void GenerateCombos(int[] arr, int index, int start, int end)
    {
        if (index >= arr.Length)
        {
            Console.WriteLine(string.Join(" ", arr));
            return;
        }

        for (int i = start; i <= end; i++)
        {
            arr[index] = i;
            GenerateCombos(arr, index + 1, i, end);
        }
    }
}