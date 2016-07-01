using System;
using System.Collections.Generic;
using System.Linq;

class LongestSubsequence
{
    static void Main()
    {
        var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var longestEqualSubsequence = GetLongestEqualSubsequence(sequence);

        Console.WriteLine(string.Join(" ", longestEqualSubsequence));
    }

    static List<T> GetLongestEqualSubsequence<T>(IList<T> sequence) where T : IComparable<T>
    {
        int startIndex = -1;
        int maxSeqCount = 0;
        int currentSeqCount = 1;
        for (int i = 1; i < sequence.Count; i++)
        {
            if (sequence[i].CompareTo(sequence[i -1]) == 0)
            {
                currentSeqCount++;
                continue;
            }

            if (maxSeqCount < currentSeqCount)
            {
                maxSeqCount = currentSeqCount;
                startIndex = i - maxSeqCount;
            }

            currentSeqCount = 1;
        }

        if (maxSeqCount < currentSeqCount)
        {
            maxSeqCount = currentSeqCount;
            startIndex = sequence.Count - maxSeqCount;
        }

        var result = new List<T>(sequence.Skip(startIndex).Take(maxSeqCount));

        return result;
    }
}