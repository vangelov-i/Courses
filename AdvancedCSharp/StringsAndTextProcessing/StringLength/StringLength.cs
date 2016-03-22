namespace StringLength
{
    using System;

    class StringLength
    {
        static void Main()
        {
            string message = Console.ReadLine();

            string result = string.Empty;

            if (message.Length < 20)
            {
                result = message.Substring(0, message.Length).PadRight(20, '*');
            }
            else
            {
                result = message.Substring(0, 20);
            }

            Console.WriteLine(result);
        }
    }
}
