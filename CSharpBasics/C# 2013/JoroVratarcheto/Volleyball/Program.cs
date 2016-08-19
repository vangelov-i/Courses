using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string leapYear = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine()); // p
            int homeTownWknd = int.Parse(Console.ReadLine()); // h

            double PlayingDaysHol = holidays * (2.0/(3.0));
            double PlayWkndNormal = (48 - homeTownWknd) * (3.0 /4.0);
            double result = PlayingDaysHol + PlayWkndNormal + homeTownWknd;
            if (leapYear == "leap")
            {
                result += result * 0.15;
            }
            Console.WriteLine((int)result);
        }
    }
}
