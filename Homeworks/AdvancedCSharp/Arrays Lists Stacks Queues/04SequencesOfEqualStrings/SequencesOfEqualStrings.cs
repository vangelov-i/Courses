namespace _04SequencesOfEqualStrings
{
    using System;
    using System.Text;

    class SequencesOfEqualStrings
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            var result = new StringBuilder();

            for (int index = 0; index < input.Length; index++)
            {
                result.AppendFormat("{0} ", input[index]);

                if (index == input.Length - 1 || input[index] != input[index + 1])
                {
                    result.AppendLine();
                }
            }

            Console.Write(result.ToString());
        }
    }
}