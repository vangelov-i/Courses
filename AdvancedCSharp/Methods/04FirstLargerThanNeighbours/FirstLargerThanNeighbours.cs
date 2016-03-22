namespace _04FirstLargerThanNeighbours
{
    using System;
    using _03LargerThanNeighbours;

    public class FirstLargerThanNeighbours
    {
        public static void Main()
        {
            int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1, 1 };

            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
        }

        private static int GetIndexOfFirstElementLargerThanNeighbours(int[] numbers)
        {
            int result = -1;

            for (int position = 0; position < numbers.Length; position++)
            {
                bool isBiggerThanNeighbours = LargerThanNeighbours.IsLargerThanNeighbours(numbers, position);

                if (isBiggerThanNeighbours)
                {
                    result = position;

                    return result;
                }
            }

            return result;
        }
    }
}