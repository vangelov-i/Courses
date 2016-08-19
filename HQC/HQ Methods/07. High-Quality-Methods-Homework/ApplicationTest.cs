namespace Methods
{
    using System;

    using Methods.Utilities.Math;

    public static class ApplicationTest
    {
        private static void Main()
        {
            Console.WriteLine(MathUtilities.CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(MathUtilities.DigitToWord(5));

            Console.WriteLine(MathUtilities.FindMaxElement(5, -1, 3, 2, 14, 2, 3));

            PrintNumberUtilities.PrintNumberWithTwoDecimalPlaces(1.3);

            PrintNumberUtilities.PrintNumberAsPercentage(0.75);

            PrintNumberUtilities.PrintNumberWithEightSpacecInfront(2.30);

            Console.WriteLine(MathUtilities.CalculateDistance(3, -1, 3, 2.5));

            bool horizontal = MathUtilities.IsHorizontal(-1, 2.5);
            bool vertical = MathUtilities.IsVertical(3, 3);
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov", "From Sofia, born at 17/03/1992");
            Student stella = new Student("Stella", "Markova", "From Vidin, gamer, high results, born at 03.11.1993");
            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}