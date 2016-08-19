using System;

namespace After10Years
{
    class AgeAfter10Years
    {
        static void Main()
        {
            DateTime bday = DateTime.Parse(Console.ReadLine());
            int ageNow = (int)(DateTime.Now - bday).TotalDays / 365;
            int age10years = (int)(DateTime.Now - bday).TotalDays / 365 + 10;
                Console.WriteLine("{0},{1}", ageNow, age10years);

        }
    }
}
