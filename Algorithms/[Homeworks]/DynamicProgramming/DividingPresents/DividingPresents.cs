using System;
using System.Collections.Generic;
using System.Linq;

class DividingPresents
{
    static void Main()
    {
        //int[] presents = { 3, 2, 3, 2, 2, 77, 89, 23, 90, 11 };
        int[] presents = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
        int targetSum = presents.Sum() / 2;

        IDictionary<int, int> subsetSums = new Dictionary<int, int>();
        subsetSums.Add(0, 0);
        int minDifferenceValue = int.MaxValue;
        int minDifferenceKey = -1;

        foreach (int present in presents)
        {
            IDictionary<int, int> subsetToAdd = new Dictionary<int, int>();
            foreach (var sum in subsetSums.Keys)
            {
                int newSum = sum + present;
                if (newSum > targetSum)
                {
                    continue;
                }

                subsetToAdd.Add(newSum, present);

                int currentDifference = targetSum - newSum;
                if (currentDifference <= minDifferenceValue)
                {
                    minDifferenceValue = currentDifference;
                    minDifferenceKey = newSum;
                }
            }

            foreach (var sum in subsetToAdd)
            {
                if (!subsetSums.ContainsKey(sum.Key))
                {
                    subsetSums.Add(sum.Key, sum.Value);
                }
            }
        }

        var alansPresents = new List<int>();
        int nextSum = minDifferenceKey;
        while (nextSum > 0)
        {
            int presentToAdd = subsetSums[nextSum];
            alansPresents.Add(presentToAdd);

            nextSum -= presentToAdd;
        }

        int alansPresentsCount = alansPresents.Sum();
        int bobsPresentsCount = presents.Sum() - alansPresentsCount;

        Console.WriteLine("Difference: " + (bobsPresentsCount - alansPresentsCount));
        Console.WriteLine("Alan:{0} Bob:{1}", alansPresentsCount, bobsPresentsCount);
        Console.WriteLine("Alan takes: " + string.Join(" ", alansPresents));
        Console.WriteLine("Bob takes the rest.");
    }
}