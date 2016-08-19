using System;
namespace _10.BeerTime
{
    class BeerTime
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Please enter daytime in format hh:mm tt (an hour in range [01...12], a minute in range [00…59] and AM / PM designator");
                int hour = (int)DateTime.Parse(Console.ReadLine()).Hour;
                if (hour >= 13 || hour < 3)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("invalid time");
            }
        }
    }
}
