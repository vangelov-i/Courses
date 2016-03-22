namespace _03CategorizeNumbersFindMinMaxAvg
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CategorizeNumbersFindMinMaxAvg
    {
        static void Main()
        {
            string[] numbersAsString = Console.ReadLine().Split();

            double[] numbers = numbersAsString.Select(double.Parse).ToArray();

            double minRoundElement = double.MaxValue;
            double maxRoundElement = 0.0;
            double sumRoundElements = 0.0;

            double minFractionElement = double.MaxValue;
            double maxFractionElement = 0.0;
            double sumFractionElements = 0.0;

            Queue<double> roundNumbers = new Queue<double>();
            Queue<double> fractionNumbers = new Queue<double>();

            foreach (double number in numbers)
            {
                if (number % 1 == 0)
                {
                    roundNumbers.Enqueue(number);
                    sumRoundElements += number;

                    if (number < minRoundElement)
                    {
                        minRoundElement = number;
                    }

                    if (number > maxRoundElement)
                    {
                        maxRoundElement = number;
                    }
                }
                else
                {
                    fractionNumbers.Enqueue(number);
                    sumFractionElements += number;

                    if (number < minFractionElement)
                    {
                        minFractionElement = number;
                    }

                    if (number > maxFractionElement)
                    {
                        maxFractionElement = number;
                    }
                }
            }

            double avaregeRoundElement = sumRoundElements / roundNumbers.Count;
            double avaregeFractionElement = sumFractionElements / fractionNumbers.Count;

            Console.WriteLine(
                "[{0}] -> min: {1:F2}, max: {2:F2}, sum: {3:F2}, avg: {4:F2}",
                string.Join(", ", fractionNumbers),
                minFractionElement,
                maxFractionElement,
                sumFractionElements,
                avaregeFractionElement);

            Console.WriteLine(
                "[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4}",
                string.Join(", ", roundNumbers),
                minRoundElement,
                maxRoundElement,
                sumRoundElements,
                avaregeRoundElement);
        }
    }
}