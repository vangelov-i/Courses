namespace _04TextFilter
{
    using System;
    using System.Linq;

    class TextFilter
    {
        static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string message = Console.ReadLine();

            // converted this to the LINQ expression bellow
            // for (int i = 0; i < bannedWords.Length; i++)
            // {
            //     message = message.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
            // }

            message = bannedWords.Aggregate(message, (current, word) => current.Replace(word, new string('*', word.Length)));

            Console.WriteLine(message);
        }
    }
}
