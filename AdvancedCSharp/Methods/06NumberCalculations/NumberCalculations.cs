namespace _06NumberCalculations
{
    using System;

    public class NumberCalculations
    {
        public static void Main()
        {
            double[] sequenceOne = { 1.1, 2.2, 3, 3, 4.4, 5.5, 6.6 };
            decimal[] sequenceTwo = { 10.0m, 11.1m, 12.2m, 13.3m, 14.4m, 15.5m };

            double minElementOne = GetMinElement(sequenceOne);
            double maxElementOne = GetMaxElement(sequenceOne);
            double sumOne = GetSum(sequenceOne);
            double avaregeOne = GetAvaregeElement(sequenceOne);
            double productOne = GetProduct(sequenceOne);

            Console.WriteLine("Double set:");
            Console.WriteLine("Min: " + minElementOne);
            Console.WriteLine("Max: " + maxElementOne);
            Console.WriteLine("Sum: " + sumOne);
            Console.WriteLine("Avg: " + avaregeOne);
            Console.WriteLine("Product: " + productOne);
            Console.WriteLine();

            decimal minElementTwo = GetMinElement(sequenceTwo);
            decimal maxElementTwo = GetMaxElement(sequenceTwo);
            decimal sumTwo = GetSum(sequenceTwo);
            decimal avaregeTwo = GetAvaregeElement(sequenceTwo);
            decimal productTwo = GetProduct(sequenceTwo);

            Console.WriteLine("Decimal set:");
            Console.WriteLine("Min: " + minElementTwo);
            Console.WriteLine("Max: " + maxElementTwo);
            Console.WriteLine("Sum: " + sumTwo);
            Console.WriteLine("Avg: " + avaregeTwo);
            Console.WriteLine("Product: " + productTwo);
        }

        private static double GetMinElement(double[] numbers)
        {
            double minElement = double.MaxValue;

            for (int index = 0; index < numbers.Length; index++)
            {
                double currentElement = numbers[index];
                if (currentElement < minElement)
                {
                    minElement = currentElement;
                }
            }

            return minElement;
        }

        private static decimal GetMinElement(decimal[] numbers)
        {
            decimal minElement = decimal.MaxValue;

            for (int index = 0; index < numbers.Length; index++)
            {
                decimal currentElement = numbers[index];
                if (currentElement < minElement)
                {
                    minElement = currentElement;
                }
            }

            return minElement;
        }

        private static double GetMaxElement(double[] numbers)
        {
            double maxElement = double.MinValue;

            for (int index = 0; index < numbers.Length; index++)
            {
                double currentElement = numbers[index];
                if (currentElement > maxElement)
                {
                    maxElement = currentElement;
                }
            }

            return maxElement;
        }

        private static decimal GetMaxElement(decimal[] numbers)
        {
            decimal maxElement = decimal.MinValue;

            for (int index = 0; index < numbers.Length; index++)
            {
                decimal currentElement = numbers[index];
                if (currentElement > maxElement)
                {
                    maxElement = currentElement;
                }
            }

            return maxElement;
        }

        private static double GetSum(double[] numbers)
        {
            double sum = 0;

            for (int index = 0; index < numbers.Length; index++)
            {
                sum += numbers[index];
            }

            return sum;
        }

        private static decimal GetSum(decimal[] numbers)
        {
            decimal sum = 0;

            for (int index = 0; index < numbers.Length; index++)
            {
                sum += numbers[index];
            }

            return sum;
        }

        private static double GetAvaregeElement(double[] numbers)
        {
            double avarege = GetSum(numbers) / numbers.Length;

            return avarege;
        }

        private static decimal GetAvaregeElement(decimal[] numbers)
        {
            decimal avarege = GetSum(numbers) / numbers.Length;

            return avarege;
        }

        private static double GetProduct(double[] numbers)
        {
            double product = 1;

            for (int index = 0; index < numbers.Length; index++)
            {
                product *= numbers[index];
            }

            return product;
        }

        private static decimal GetProduct(decimal[] numbers)
        {
            decimal product = 1;

            for (int index = 0; index < numbers.Length; index++)
            {
                product *= numbers[index];
            }

            return product;
        }
    }
}