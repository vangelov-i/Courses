namespace Exceptions_Homework.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class StringUtilities
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new NullReferenceException("The array cannot be null or empty.");
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "Cannot be negative.");
            }

            if (startIndex + count > arr.Length)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(startIndex),
                    nameof(count),
                    "The sum of startIndex and count cannot exceed the array's lenght.");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string inputMessage, int count)
        {
            if (count > inputMessage.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Cannot exceed the the lenght of the inputMessage.");
            }

            StringBuilder result = new StringBuilder();
            for (int currentIndex = inputMessage.Length - count; currentIndex < inputMessage.Length; currentIndex++)
            {
                result.Append(inputMessage[currentIndex]);
            }

            return result.ToString();
        }
    }
}