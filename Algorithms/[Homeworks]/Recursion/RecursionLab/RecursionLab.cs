namespace RecursionLab
{
    using System;

    class RecursionLab
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            Console.WriteLine(FindSum(arr, 3));
        }

        static long FindSum(int[] arr, int startIndex)
        {
            if (startIndex == arr.Length)
            {
                return 0;
            }

            return arr[startIndex] + FindSum(arr, startIndex + 1);
        }
    }
}
