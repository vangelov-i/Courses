namespace Knapsack_Problem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    public class Knapsack
    {
        public static void Main()
        {
            var items = new[]
            {
                new Item { Weight = 5, Price = 30 },
                new Item { Weight = 8, Price = 120 },
                new Item { Weight = 7, Price = 10 },
                new Item { Weight = 0, Price = 20 },
                new Item { Weight = 4, Price = 50 },
                new Item { Weight = 5, Price = 80 },
                new Item { Weight = 2, Price = 10 }
            };

            var knapsackCapacity = 20;

            var itemsTaken = FillKnapsack(items, knapsackCapacity);

            Console.WriteLine("Knapsack weight capacity: {0}", knapsackCapacity);
            Console.WriteLine("Take the following items in the knapsack:");
            foreach (var item in itemsTaken)
            {
                Console.WriteLine(
                    "  (weight: {0}, price: {1})",
                    item.Weight,
                    item.Price);
            }

            Console.WriteLine("Total weight: {0}", itemsTaken.Sum(i => i.Weight));
            Console.WriteLine("Total price: {0}", itemsTaken.Sum(i => i.Price));
        }

        public static Item[] FillKnapsack(Item[] items, int capacity)
        {
            int[,] bestPrices = new int[items.Length, capacity + 1];
            bool[,] itemUsed = new bool[items.Length, capacity + 1];

            for (int cap = 0; cap <= capacity; cap++)
            {
                if (items[0].Weight <= cap)
                {
                    bestPrices[0, cap] = items[0].Price;
                    itemUsed[0, cap] = true;
                }
            }

            for (int itemIndex = 1; itemIndex < bestPrices.GetLength(0); itemIndex++)
            {
                for (int currentCap = 0; currentCap < bestPrices.GetLength(1); currentCap++)
                {


                    Item currentItem = items[itemIndex];
                    if (currentItem.Weight <= currentCap)
                    {
                        if (currentItem.Price >= bestPrices[itemIndex - 1, currentCap])
                        {
                            bestPrices[itemIndex, currentCap] = currentItem.Price;
                            itemUsed[itemIndex, currentCap] = true;
                        }
                        else
                        {
                            int capacityLeft = currentCap - currentItem.Weight;

                            if (currentItem.Price + bestPrices[itemIndex - 1, capacityLeft] >= bestPrices[itemIndex - 1, currentCap])
                            {
                                bestPrices[itemIndex, currentCap] = currentItem.Price + bestPrices[itemIndex - 1, capacityLeft];
                                itemUsed[itemIndex, currentCap] = true;
                            }
                        }
                    }
                }
            }

            List<Item> result = new List<Item>();
            int row = items.Length - 1;

            while (row >= 0)
            {
                if (itemUsed[row, capacity])
                {
                    result.Add(items[row]);
                    capacity -= items[row].Weight;
                }

                row--;
            }

            return result.ToArray();
        }
    }
}
