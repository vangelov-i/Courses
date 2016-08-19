using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP5
{
    class ExerciseP5
    {
        static void Main()
        {
            Console.Write("Write a number and we\'ll tell you if it's greater than 20 and odd: ");
            int number = int.Parse(Console.ReadLine());
            bool greater20odd = number > 20 && number % 2 == 1;
            Console.WriteLine(greater20odd);
        }
    }
}
