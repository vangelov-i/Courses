using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP6
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            long number = long.Parse(Console.ReadLine());
            bool dividable = number % 9 == 0 || number % 11 == 0 || number % 13 == 0;
            if (dividable)
            {
                Console.WriteLine("The number {0} can be divided by 9,11 or 13 without reminder ({1})", number, dividable);
            }
            else 
            {
                Console.WriteLine("The number {0} can\'t be divided by 9, 11 or 13 without a reminder ({1})", number,dividable);
            }
        }
    }
}
