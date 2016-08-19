using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Trim().Split();
        int[] bitsSequence = input.Select(int.Parse).ToArray();
        string binarySeq = string.Join("", input);
        int num = Convert.ToInt32(binarySeq, 2);

        var result = FindLongestIncreasingSubsequence(bitsSequence);

        Console.WriteLine(result[0] < 0 ? result[1] : result[1] + 1);
    }

    public static int[] FindLongestIncreasingSubsequence(int[] sequence)
    {
        int[] len = new int[sequence.Length];
        int[] prev = new int[sequence.Length];
        int maxLength = 0;
        int lastIndex = -1;


        int maxOnes = 0;
        int totalBitsPassed = 0;
        int startIndex = -1;

        for (int x = 0; x < sequence.Length; x++)
        {
            if (sequence[x] == 1)
            {
                continue;
            }

            int index = x;
            len[index] = 0;
            int bitsPassed = 0;

            while (index < sequence.Length)
            {
                while (index < sequence.Length && sequence[index] == 0)
                {
                    len[x]++;
                    bitsPassed++;
                    index++;
                }

                if (maxOnes < len[x])
                {
                    maxOnes = len[x];
                    totalBitsPassed = bitsPassed;
                    startIndex = index - totalBitsPassed;
                }

                while (index < sequence.Length && sequence[index] == 1)
                {
                    len[x]--;
                    bitsPassed++;
                    index++;
                }

                if (maxOnes < len[x])
                {
                    maxOnes = len[x];
                    totalBitsPassed = bitsPassed;
                    startIndex = index - totalBitsPassed;
                }
            }
        }

        return new[] { startIndex, totalBitsPassed };
    }
}