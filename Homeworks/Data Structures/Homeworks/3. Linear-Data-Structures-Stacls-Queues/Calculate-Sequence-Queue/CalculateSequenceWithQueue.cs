using System;
using System.Collections.Generic;
using System.Linq;

class CalculateSequenceWithQueue
{
    static void Main()
    {
        int startElement = int.Parse(Console.ReadLine());
        var result = new Queue<int>(50);

        var start = DateTime.Now;
        for (int i = 0; i < 100000; i++)
        {
            int element = startElement;

            var sequence = new Queue<int>(50);
            result = new Queue<int>(50);
            sequence.Enqueue(element);
            result.Enqueue(element);

            while (result.Count < 50)
            {
                element = sequence.Dequeue();

                int firstElement = element + 1;
                int secondElement = 2 * element + 1;
                int thirdElement = element + 2;

                sequence.Enqueue(firstElement);
                sequence.Enqueue(secondElement);
                sequence.Enqueue(thirdElement);

                result.Enqueue(firstElement);
                result.Enqueue(secondElement);
                result.Enqueue(thirdElement);
            }
        }
        var duration = DateTime.Now - start;

        Console.WriteLine(duration);
        for (int i = 0; i < 50; i++)
        {
            Console.Write(result.Dequeue() + " ");
        }
        Console.WriteLine();
        return;
        Console.WriteLine(string.Join(" ", result.Take(50)));
    }
}