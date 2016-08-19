using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_IntroductionToProgramming
{
    class P1Avarege
    {
        static void Main()
        {
            Console.WriteLine ("Please enter three numbers (a, b, c): ");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float avarege = (a+b+c)/3;
            Console.WriteLine("The avarege of these three numbers is {0}", avarege);

        }
    }
}
