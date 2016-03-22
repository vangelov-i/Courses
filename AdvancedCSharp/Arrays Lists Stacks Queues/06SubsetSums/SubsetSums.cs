namespace _06SubsetSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SubsetSums
    {
        static void Main()
        {
            int sum = int.Parse(Console.ReadLine());

            string[] numbersAsString = Console.ReadLine().Split();
            int[] numbers = numbersAsString.Select(int.Parse).Distinct().ToArray();

            List<List<int>> filteredSubsets = new List<List<int>>();

            for (int i = 0; i < Math.Pow(2, numbers.Length); i++)
            {
                List<int> subsets = new List<int>();

                for (int position = 0; position < numbers.Length; position++)
                {
                    if ((i & (1 << position)) >> position == 1)
                    {
                        subsets.Add(numbers[position]);
                    }
                }

                if (subsets.Count > 0 && subsets.Sum() == sum)
                {
                    filteredSubsets.Add(subsets);
                }
            }

            if (filteredSubsets.Count > 0)
            {
                foreach (var intList in filteredSubsets)
                {

                    Console.WriteLine("{1} = {2}", string.Join(" + ", intList), sum);
                }
            }
            else
            {
                Console.WriteLine("No matching subsets.");
            }
        }
    }
}