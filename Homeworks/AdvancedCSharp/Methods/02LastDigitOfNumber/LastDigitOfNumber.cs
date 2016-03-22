namespace _02LastDigitOfNumber
{
    using System;

    public class LastDigitOfNumber
    {
        public static void Main()
        {
            Console.WriteLine(GetLastDigitAsWord(512));
            Console.WriteLine(GetLastDigitAsWord(1024));
            Console.WriteLine(GetLastDigitAsWord(12309));
        }

        private static string GetLastDigitAsWord(int number)
        {
            int lastDigit = number % 10;

            string lastDigitAsWord = string.Empty;

            if (lastDigit == 0)
            {
                lastDigitAsWord = "zero";
            }
            else if (lastDigit == 1)
            {
                lastDigitAsWord = "one";
            }
            else if (lastDigit == 2)
            {
                lastDigitAsWord = "two";
            }
            else if (lastDigit == 3)
            {
                lastDigitAsWord = "three";
            }
            else if (lastDigit == 4)
            {
                lastDigitAsWord = "four";
            }
            else if (lastDigit == 5)
            {
                lastDigitAsWord = "five";
            }
            else if (lastDigit == 6)
            {
                lastDigitAsWord = "six";
            }
            else if (lastDigit == 7)
            {
                lastDigitAsWord = "seven";
            }
            else if (lastDigit == 8)
            {
                lastDigitAsWord = "eight";
            }
            else if (lastDigit == 9)
            {
                lastDigitAsWord = "nine";
            }

            return lastDigitAsWord;
        }
    }
}