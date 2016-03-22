namespace _01SortArrayOfNumbers
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    class SortArrayOfNumbers
    {
        static void Main(string[] args)
        {
            string[] numbersAsString = Console.ReadLine().Split();

            int[] numbers = numbersAsString.Select(int.Parse).ToArray();

            Array.Sort(numbers);

            Console.WriteLine(string.Join(" ", numbers));

            // Some comparisson between sorting using LINQ and Array.Sort(array);

            // int[] numbersLINQ = numbersAsString.Select(int.Parse).ToArray();
            // int[] numberSort = numbersAsString.Select(int.Parse).ToArray();

            // Stopwatch watch = new Stopwatch();
            // watch.Start();
            // for (int i = 0; i < 1000000; i++)
            // {
            //     numbersLINQ = numbersLINQ.OrderBy(num => num).ToArray();
            // }

            // watch.Stop();

            // Console.WriteLine(watch.Elapsed);

            // watch.Reset();

            // watch.Start();
            // for (int i = 0; i < 1000000; i++)
            // {
            //     Array.Sort(numberSort);
            // }

            // watch.Stop();

            // Console.WriteLine(watch.Elapsed);
        }
    }
}
