namespace SortArrayUsingSelection
{
    using System;
    using System.Linq;

    class SortArrayUsingSelection
    {
        static void Main()
        {
            string[] numbersAsString = Console.ReadLine().Split();

            int[] numbers = numbersAsString.Select(int.Parse).ToArray();

            for (int sortedIndex = 0; sortedIndex < numbers.Length; sortedIndex++)
            {
                int currentMinElement = numbers[sortedIndex];

                for (int unsortedIndex = sortedIndex; unsortedIndex < numbers.Length; unsortedIndex++)
                {
                    if (numbers[unsortedIndex] < currentMinElement)
                    {
                        currentMinElement = numbers[unsortedIndex];

                        numbers[unsortedIndex] = numbers[sortedIndex];
                        numbers[sortedIndex] = currentMinElement;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}