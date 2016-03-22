namespace _03LargerThanNeighbours
{
    using System;

    public static class LargerThanNeighbours
    {
        public static void Main()
        {
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numbers, i));
            }
        }

        public static bool IsLargerThanNeighbours(int[] numbers, int position)
        {
            bool result = false;

            int leftNeighbour = 0;
            int currentNumber = numbers[position];
            int rightNeighbour = 0;

            if (position > 0 && position < numbers.Length - 1)
            {
                leftNeighbour = numbers[position - 1];
                rightNeighbour = numbers[position + 1];
                result = leftNeighbour < currentNumber && rightNeighbour < currentNumber;
            }
            else if (position == 0)
            {
                rightNeighbour = numbers[position + 1];

                result = rightNeighbour < currentNumber;
            }
            else
            {
                leftNeighbour = numbers[position - 1];

                result = leftNeighbour < currentNumber;
            }

            return result;
        }
    }
}
