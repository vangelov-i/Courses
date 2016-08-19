namespace Longest_Common_Subsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestCommonSubsequence
    {
        public static void Main()
        {
            var firstStr = "tree";
            var secondStr = "team";

            var lcs = FindLongestCommonSubsequence(firstStr, secondStr);

            Console.WriteLine("Longest common subsequence:");
            Console.WriteLine("  first  = {0}", firstStr);
            Console.WriteLine("  second = {0}", secondStr);
            Console.WriteLine("  lcs    = {0}", lcs);

        }

        public static string FindLongestCommonSubsequence(string firstStr, string secondStr)
        {
            string result = string.Empty;

            int[,] table = new int[firstStr.Length + 1, secondStr.Length + 1];
            for (int firstChar = 1; firstChar < table.GetLength(0); firstChar++)
            {
                for (int secondChar = 1; secondChar < table.GetLength(1); secondChar++)
                {
                    if (firstStr[firstChar - 1] == secondStr[secondChar - 1])
                    {
                        table[firstChar, secondChar] = table[firstChar - 1, secondChar - 1] + 1;
                    }
                    else
                    {
                        table[firstChar, secondChar] = Math.Max(
                            table[firstChar - 1, secondChar],
                            table[firstChar, secondChar - 1]);
                    }
                }
            }

            result = string.Join("", RetrieveLCS(firstStr, secondStr, table));

            return result;
        }

        private static List<char> RetrieveLCS(string firstStr, string secondStr, int[,] lcs)
        {
            List<char> result = new List<char>();
            int first = firstStr.Length;
            int second = secondStr.Length;
            while (first > 0 && second > 0)
            {
                if (firstStr[first - 1] == secondStr[second - 1])
                {
                    result.Add(firstStr[first - 1]);
                    first--;
                    second--;
                }
                else
                {
                    if (lcs[first,second] == lcs[first - 1, second])
                    {
                        first--;
                    }
                    else
                    {
                        second--;
                    }
                }
            }

            result.Reverse();

            return result;
        }
    }
}
