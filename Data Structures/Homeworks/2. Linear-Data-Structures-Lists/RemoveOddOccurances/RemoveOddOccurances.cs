using System;
using System.Collections.Generic;
using System.Linq;

class RemoveOddOccurances
{
    static void Main()
    {
        var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var result = new List<int>(sequence.Length);
        var oddOccurancesNums = new HashSet<int>();
        var evenOccurancesNums = new HashSet<int>();

        for (int index = 0; index < sequence.Length; index++)
        {
            int currentNum = sequence[index];
            if (oddOccurancesNums.Contains(currentNum))
            {
                continue;
            }

            if (evenOccurancesNums.Contains(currentNum))
            {
                result.Add(currentNum);
                continue;
            }

            int currentOccurances = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i].CompareTo(currentNum) == 0)
                {
                    currentOccurances++;
                }
            }

            if (currentOccurances % 2 == 0)
            {
                result.Add(currentNum);
                evenOccurancesNums.Add(currentNum);
            }
            else
            {
                oddOccurancesNums.Add(currentNum);
            }
        }

        Console.WriteLine(string.Join(" ", result));
    }
}