using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2GravitationMoon
{
    class P2GravitationMoon
    {
        static void Main()
        {
            start:
            Console.Write("Please enter your weight in kg: ");
            float earthWeight = float.Parse(Console.ReadLine());
            float moonWeight = earthWeight - (0.83f * earthWeight);
            Console.WriteLine("Your weight on the moon will be: {0:F3} kg", moonWeight);
            goto start;
        }
    }
}
