using System;
using System.Globalization;
using System.Threading;

namespace _12AprilEveningExamSchedule
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            string partDay = Console.ReadLine();
            int durHours = int.Parse(Console.ReadLine());
            int durMin = int.Parse(Console.ReadLine());

            string startTime = hour + ":" +minutes + " "+ partDay;
            DateTime start = DateTime.Parse(startTime).AddHours(durHours).AddMinutes(durMin);
            Console.WriteLine("{0:hh:mm:tt}",start);
        }
    }
}
//16:42