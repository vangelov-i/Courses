using System;

namespace Jorkata
{
    class Program
    {
        static void Main()
        {
            string leapYear = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine()); // p
            int hometownWeekends = int.Parse(Console.ReadLine()); // h

            int normalWknds = 52 - hometownWeekends;

            double result = ((normalWknds*2)/3) + ((double)holidays/2) + hometownWeekends;
            if (leapYear == "t")
            {
                result += 3;
            }
            Console.WriteLine((int)result);
        }
    }
}
