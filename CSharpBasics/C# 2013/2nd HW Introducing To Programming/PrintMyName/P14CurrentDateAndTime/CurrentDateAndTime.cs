using System;
using System.Globalization;
using System.Threading;

namespace P14CurrentDateAndTime
{
    class CurrentDateAndTime
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            Console.WriteLine(DateTime.Now);
        }
    }
}
