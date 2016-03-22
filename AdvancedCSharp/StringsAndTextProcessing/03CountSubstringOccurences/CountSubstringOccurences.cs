namespace _03CountSubstringOccurences
{
    using System;

    class CountSubstringOccurences
    {
        static void Main()
        {
            string message = Console.ReadLine();
            string substringToFind = Console.ReadLine();

            int index = -1;
            int occurances = 0;

            index = message.ToLower().IndexOf(substringToFind.ToLower(), index + 1);

            while (index != -1)
            {
                occurances++;
                index = message.ToLower().IndexOf(substringToFind.ToLower(), index + 1);
            }

            Console.WriteLine(occurances);
        }
    }
}
