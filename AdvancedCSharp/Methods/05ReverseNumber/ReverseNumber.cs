namespace _05ReverseNumber
{
    using System;
    using System.Text;

    public class ReverseNumber
    {
        public static void Main()
        {
            double initialNumber = double.Parse(Console.ReadLine());

            double reversed = GetReversedNumber(initialNumber);

            Console.WriteLine(reversed);
        }

        private static double GetReversedNumber(double number)
        {
            string numberAsString = number.ToString();
            var stringResult = new StringBuilder();

            for (int currentChar = numberAsString.Length - 1; currentChar >= 0; currentChar--)
            {
                stringResult.Append(numberAsString[currentChar]);
            }

            double result = double.Parse(stringResult.ToString());

            return result;
        }
    }
}