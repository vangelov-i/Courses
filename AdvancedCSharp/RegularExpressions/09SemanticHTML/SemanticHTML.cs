
namespace _09SemanticHTML
{
    using System;
    using System.Text;

    public class SemanticHTML
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            var input = new StringBuilder();

            while (inputLine != "END")
            {
                input.Append(inputLine);

                inputLine = Console.ReadLine();
            }


        }
    }
}
