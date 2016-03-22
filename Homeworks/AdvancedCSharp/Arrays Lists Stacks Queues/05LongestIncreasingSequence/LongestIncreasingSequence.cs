namespace _05LongestIncreasingSequence
{
    using System;
    using System.Linq;
    using System.Text;

    class LongestIncreasingSequence
    {
        static void Main()
        {
            string[] numbersAsString = Console.ReadLine().Split();

            int[] numbers = numbersAsString.Select(int.Parse).ToArray();

            int biggestSequenceCount = 0;
            int currentSequenceCount = 0;
            int biggestSequenceEndIndex = 0;

            var result = new StringBuilder();

            for (int index = 0; index < numbers.Length; index++)
            {
                result.AppendFormat("{0} ", numbers[index]);
                currentSequenceCount++;

                if (currentSequenceCount > biggestSequenceCount)
                {
                    biggestSequenceCount = currentSequenceCount;
                    biggestSequenceEndIndex = index + 1;
                }

                if (index != numbers.Length - 1 && numbers[index + 1] <= numbers[index])
                {
                    result.AppendLine();
                    currentSequenceCount = 0;
                }
            }

            result.AppendLine();

            int[] biggestIncreasingSequence =
                numbers.Skip(biggestSequenceEndIndex - biggestSequenceCount).Take(biggestSequenceCount).ToArray();

            Console.WriteLine("{0}Longest: {1}", result, string.Join(" ", biggestIncreasingSequence));
        }
    }
}
