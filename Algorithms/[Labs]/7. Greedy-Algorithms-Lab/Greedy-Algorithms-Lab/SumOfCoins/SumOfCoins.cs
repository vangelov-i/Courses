namespace SumOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumOfCoins
    {
        public static void Main(string[] args)
        {
            var availableCoins = new[] { 1, 2, 5, 10, 20, 50 };
            var targetSum = 923;

            try
            {
                var selectedCoins = ChooseCoins(availableCoins, targetSum);
                Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
                foreach (var selectedCoin in selectedCoins)
                {
                    Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
                }

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error");
            }

        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            var result = new Dictionary<int, int>();
            int currentSum = 0;
            var orderedCoins = coins.OrderBy(c => c).ToList();

            for (int i = orderedCoins.Count - 1; i >= 0; i--)
            {
                if (currentSum == targetSum)
                {
                    break;
                }

                int currentCoin = orderedCoins[i];
                int remainingSum = targetSum - currentSum;
                int multiplier = remainingSum / currentCoin;

                if (multiplier != 0)
                {
                    if (!result.ContainsKey(currentCoin))
                    {
                        result[currentCoin] = 0;
                    }

                    currentSum += multiplier * currentCoin;
                    result[currentCoin] += multiplier;
                }

            }

            if (currentSum < targetSum)
            {
                throw new InvalidOperationException("The given coins cannot form the target sum.");
            }

            return result;
        }
    }
}