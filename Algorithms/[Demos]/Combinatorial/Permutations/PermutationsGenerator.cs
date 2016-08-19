using System;

class PermutationsGenerator
{
    static void Main()
    {
        string[] arr = { "apple", "banana", "orange" };
        GeneratePermutations(arr);
    }

    static void GeneratePermutations<T>(T[] arr, int index = 0)
    {
        if (index >= arr.Length)
        {
            Print(arr);
        }
        else
        {
            GeneratePermutations(arr, index + 1);
            for (int i = index + 1; i < arr.Length; i++)
            {
                Swap(ref arr[index], ref arr[i]);
                GeneratePermutations(arr, index + 1);
                Swap(ref arr[index], ref arr[i]);
            }
        }
    }

    static void Print<T>(T[] arr)
    {
        Console.WriteLine("(" + string.Join(", ", arr) + ")");
    }

    static void Swap<T>(ref T first, ref T second)
    {
        T oldFirst = first;
        first = second;
        second = oldFirst;
    }
}
