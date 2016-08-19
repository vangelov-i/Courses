using System;

namespace _11AprilEvening01Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int seats = rows * columns;
            double incomes = 0.0;
            switch (projType)
            {
                case "Premiere":
                    incomes = (double)seats * 12.00;
                    break;
                case "Normal":
                    incomes = (double)seats * 7.50;
                    break;
                default:
                    incomes = (double)seats * 5.00;
                    break;
            }
            Console.WriteLine("{0:F2} leva", incomes);
        }
    }
}
