using System;
using System.Linq;

class CountOccurrences
{
    static void Main()
    {
        var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var sortedSequence = sequence.OrderBy(n => n).ToArray();

        for (int index = 0; index < sortedSequence.Length; index++)
        {
            int currentNum = sortedSequence[index];
            int occurances = 1;
            while (index < sortedSequence.Length - 1 && currentNum == sortedSequence[index + 1])
            {
                occurances++;
                index++;
            }

            Console.WriteLine(currentNum + " -> " + occurances + " times");
        }
    }
}