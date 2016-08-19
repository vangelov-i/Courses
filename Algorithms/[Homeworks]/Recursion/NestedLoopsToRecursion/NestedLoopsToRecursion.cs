using System;

class NestedLoopsToRecursion
{
    static void Main()
    {
        int members = int.Parse(Console.ReadLine());

        int[] arr = new int[members];

        GenerateCombos(arr, 0, 1, members);
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
            GenerateCombos(arr, index + 1, start, end);
        }
    }
}