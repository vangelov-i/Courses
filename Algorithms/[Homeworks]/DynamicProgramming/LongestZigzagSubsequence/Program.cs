using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //int[] sequence = { 24, 5, 31, 3, 3, 342, 51, 114, 52, 55, 56, 58 };
        //int[] sequence = { 8, 3, 5, 7, 0, 8, 9, 10, 20, 20, 20, 12, 19, 11 };
        //int[] sequence = { 1, 2, 3 };
        //int[] sequence = { 1,3,2 };
        //int[] sequence = { 0, 1, 1, 5, 8, 3, 2, 1 };
        int[] sequence = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

        int[] length = new int[sequence.Length];
        int[] wasIncreased = new int[sequence.Length];
        int[] previousIndexes = new int[sequence.Length];

        int lastIndex = -1;
        int maxLength = 0;

        for (int index = 0; index < sequence.Length; index++)
        {
            length[index] = 1;
            previousIndexes[index] = -1;

            for (int prevIndex = 0; prevIndex < index; prevIndex++)
            {
                if (wasIncreased[prevIndex] == -1 && sequence[index] > sequence[prevIndex] && length[prevIndex] + 1 > length[index])
                {
                    wasIncreased[index] = 1;
                    length[index] = length[prevIndex] + 1;
                    previousIndexes[index] = prevIndex;
                }
                else if (wasIncreased[prevIndex] == 1 && sequence[index] < sequence[prevIndex]
                         && length[prevIndex] + 1 > length[index])
                {
                    wasIncreased[index] = -1;
                    length[index] = length[prevIndex] + 1;
                    previousIndexes[index] = prevIndex;
                }
                else if (wasIncreased[prevIndex] == 0 && length[prevIndex] + 1 > length[index])
                {
                    wasIncreased[index] = sequence[index] > sequence[prevIndex] ? 1 : -1;
                    length[index] = length[prevIndex] + 1;
                    previousIndexes[index] = prevIndex;
                }
            }

            if (length[index] > maxLength)
            {
                maxLength = length[index];
                lastIndex = index;
            }
        }

        Console.WriteLine("Longest zig-zag subsequence length: " + length.Max());

        var longestZigZagSeq = new List<int>();

        int currentIndex = lastIndex;
        while (currentIndex != -1)
        {
            longestZigZagSeq.Add(sequence[currentIndex]);

            currentIndex = previousIndexes[currentIndex];
        }

        longestZigZagSeq.Reverse();
        Console.WriteLine(string.Join(" ", longestZigZagSeq));
    }
}