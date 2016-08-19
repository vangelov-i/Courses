namespace VariationsWithoutRepetitions
{
    using System;

    class VariationsWithoutRepetition
    {
        private static bool[] used;

        //static void Main()
        //{
        //    int n = int.Parse(Console.ReadLine());
        //    int k = int.Parse(Console.ReadLine());
        //    int[] arr = new int[k];

        //    used = new bool[n + 1];
        //    GenerateVariationsWithoutRep(arr, n);
        //}

        //static void GenerateVariationsWithoutRep(int[] arr, int n, int index = 0)
        //{
        //    if (index >= arr.Length)
        //    {
        //        Console.WriteLine(string.Join(" ", arr));
        //        return;
        //    }

        //    for (int i = 1; i <= n; i++)
        //    {
        //        if (!used[i])
        //        {
        //            arr[index] = i;
        //            used[i] = true;
        //            GenerateVariationsWithoutRep(arr, n, index + 1);
        //            used[i] = false;
        //        }
        //    }
        //}

        static void Main()
        {
            int[] arr = { 1, 2, 3 };
            int k = 2;

            GenerateVariationsWithRepetition(arr, 0, k);
        }

        private static int[] combos = new int[2];

        static void GenerateVariationsWithRepetition(int[] arr, int index, int k)
        {
            if (index == k)
            {
                Console.WriteLine(string.Join(" ", combos));
                return;
            }

            for (int i = index; i < arr.Length; i++)
            {
                combos[index] = arr[i];

                int first = arr[index];
                arr[index] = arr[i];
                arr[i] = first;

                GenerateVariationsWithRepetition(arr, index + 1, k);
                first = arr[index];
                arr[index] = arr[i];
                arr[i] = first;
            }
        }
    }
}