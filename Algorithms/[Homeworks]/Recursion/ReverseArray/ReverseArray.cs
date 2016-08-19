namespace ReverseArray
{
    using System;
    using System.Linq;

    class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            //string[] arr = Console.ReadLine().Split(' ');

            Reverse(arr);

            Console.WriteLine(string.Join(" ", arr));
        }

        private static void Reverse<T>(T[] arr)
        {
            Reverse(arr, 0, arr.Length-1);
        }

        private static void Reverse<T>(T[] arr, int firstIndexToSwitch, int lastIndexToSwitch)
        {
            if (firstIndexToSwitch >= lastIndexToSwitch)
            {
                return;
            }

            T first = arr[firstIndexToSwitch];
            arr[firstIndexToSwitch] = arr[lastIndexToSwitch];
            arr[lastIndexToSwitch] = first;

            Reverse(arr, firstIndexToSwitch + 1, lastIndexToSwitch -1);
        }
    }
}
