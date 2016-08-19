using System;
using System.Collections.Generic;
using System.Linq;

class SumWithLimitedAmountOfCoins
{
    private static int targetSum;
    private static int[] coins;
    private static int totalSums;

    public static void Main(string[] args)
    {
        targetSum = int.Parse(Console.ReadLine());
        coins = Console.ReadLine()
            .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .OrderBy(i => i)
            .ToArray();

        CalculatePossibleSums(targetSum, coins.Length - 1);
        Console.WriteLine(totalSums);
    }

    private static List<int> subset = new List<int>();

    private static void CalculatePossibleSums(int sum, int start)
    {
        if (sum == 0)
        {
            totalSums++;
            Console.WriteLine(targetSum + " = " + string.Join(" + ", subset));
            return;
        }

        if (sum < 0)
        {
            return;
        }

        for (int index = start; index >= 0; index--)
        {
            int currentSum = sum - coins[index];

            subset.Add(coins[index]);
            CalculatePossibleSums(currentSum, index - 1);

            while (index > 0 && coins[index] == coins[index - 1])
            {
                index--;
            }

            subset.RemoveAt(subset.Count - 1);
        }
    }
}