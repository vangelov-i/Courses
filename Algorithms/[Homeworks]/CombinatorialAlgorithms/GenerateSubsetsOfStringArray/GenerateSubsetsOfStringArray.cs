using System;
using System.Linq;

class GenerateSubsetsOfStringArray
{
    private static string[] elements;

    static void Main(string[] args)
    {
        elements = Console.ReadLine().Substring(4).Split(
            new[] { ' ', ',', '=', '{', '}' },
            StringSplitOptions.RemoveEmptyEntries);

        int n = elements.Length;
        int k = int.Parse(Console.ReadLine().Substring(4));

        int[] array = new int[k];

        GenCombosWithoutRepetition(array);
    }

    static void GenCombosWithoutRepetition(int[] array, int index = 0, int start = 0)
    {
        if (index >= array.Length)
        {
            Console.WriteLine("( {0} )", string.Join(", ", array.Select(i => elements[i])));

            return;
        }
        
        for (int i = start; i < elements.Length; i++)
        {
            array[index] = i;
            GenCombosWithoutRepetition(array, index + 1, i + 1);
        }
    }
}