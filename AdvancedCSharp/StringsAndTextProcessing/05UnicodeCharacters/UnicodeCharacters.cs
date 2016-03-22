namespace _05UnicodeCharacters
{
    using System;
    using System.Text;

    class UnicodeCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var result = new StringBuilder();

            foreach (char symbol in input)
            {
                result.Append("\\u" + ((int)symbol).ToString("X4"));
            }

            Console.WriteLine(result.ToString());
        }
    }
}
