using System;

namespace _11AprilMorning01WorkHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int freeDays = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double productivity = (double)(percent) / 100;
            double realDaysWork = (freeDays- (freeDays*0.1));
            int hoursOfWork = (int)(realDaysWork * 12 * productivity);
            if (neededHours > hoursOfWork)
            {
                Console.WriteLine("No");
                Console.WriteLine(hoursOfWork - neededHours);
            }
            else
            {
                Console.WriteLine("Yes");
                Console.WriteLine(hoursOfWork - neededHours);
            }

        }
    }
}
//17:30