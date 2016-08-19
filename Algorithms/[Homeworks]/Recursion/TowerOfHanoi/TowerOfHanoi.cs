namespace TowerOfHanoi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TowerOfHanoi
    {
        private static Stack<int> source;
        private static Stack<int> spare = new Stack<int>();
        private static Stack<int> destionation = new Stack<int>();

        private static int stepsTaken;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            source = new Stack<int>(Enumerable.Range(1, n).Reverse());

            PrintRods();
            SolveHanoi(source.Count, source, spare, destionation);
        }

        private static void SolveHanoi(int bottomDisk, Stack<int> source, Stack<int> spare, Stack<int> destination)
        {
            if (bottomDisk == 1)
            {
                stepsTaken++;
                destination.Push(source.Pop());
                Console.WriteLine("Step #{0}: Moved disk {1}", stepsTaken, destination.Peek());
                PrintRods();
            }
            else
            {
                SolveHanoi(bottomDisk - 1, source, destination, spare);
                SolveHanoi(1, source, spare, destination);
                SolveHanoi(bottomDisk -1, spare, source, destination);
            }
        }

        private static void PrintRods()
        {
            Console.WriteLine("Source: {0}", string.Join(", ", source.Reverse()));
            Console.WriteLine("Destination: {0}", string.Join(", ", destionation.Reverse()));
            Console.WriteLine("Spare: {0}", string.Join(", ", spare.Reverse()));
            Console.WriteLine();
        }
    }
}