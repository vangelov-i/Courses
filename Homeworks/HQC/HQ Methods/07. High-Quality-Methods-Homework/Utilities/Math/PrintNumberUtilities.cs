namespace Methods.Utilities.Math
{
    using System;

    public static class PrintNumberUtilities
    {
        public static void PrintNumberWithTwoDecimalPlaces(object number)
        {
            ValidateNumber(number);

            Console.WriteLine("{0:F2}", number);
        }

        public static void PrintNumberAsPercentage(object number)
        {
            ValidateNumber(number);

            Console.WriteLine("{0:P0}", number);
        }

        public static void PrintNumberWithEightSpacecInfront(object number)
        {
            ValidateNumber(number);

            Console.WriteLine("{0,8}", number);
        }

        private static void ValidateNumber(object value)
        {
            bool isNumber = 
                value is sbyte || value is byte || 
                value is short || value is ushort || 
                value is int || value is uint || 
                value is long || value is ulong || 
                value is float || 
                value is double || 
                value is decimal;
            if (!isNumber)
            {
                throw new ArgumentException("Invalid number. The input is not a number.");
            }
        }
    }
}