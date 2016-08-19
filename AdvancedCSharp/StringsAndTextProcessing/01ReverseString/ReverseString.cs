namespace _01ReverseString
{
    using System;
    using System.Linq;
    using System.Text;

    class ReverseString
    {
        static void Main()
        {
            string message = Console.ReadLine();

            message = new string(message.Reverse().ToArray());

            Console.WriteLine(message);

            // 2nd option
            // var reversedMessage = new StringBuilder();
               
            // for (int i = message.Length - 1; i >= 0; i--)
            // {
            //     reversedMessage.Append(message[i]);
            // }

            // Console.WriteLine(reversedMessage.ToString());
        }
    }
}
