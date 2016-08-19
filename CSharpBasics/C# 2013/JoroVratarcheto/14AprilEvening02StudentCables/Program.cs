using System;

//12:30 - 13:45

namespace _14AprilEvening02StudentCables
{
    class Program
    {
        static void Main(string[] args)
        {
            int cablesNum = int.Parse(Console.ReadLine());
            int currentLenght = 0;
            int tempWholeCables = 0;
            int totalLenght = 0;
            string measure = string.Empty;
            for (int i = 0; i < cablesNum; i++)
            {
                currentLenght = int.Parse(Console.ReadLine());
                measure = Console.ReadLine();
                if (measure == "meters")
                {
                    currentLenght *= 100;
                }
                //tempWholeCables = currentLenght / 504;
                if (currentLenght >= 20)
                {
                    totalLenght += currentLenght - 3;
                }
                //if (tempWholeCables > 0)
                //{
                //    totalLenght += ((tempWholeCables-1)*3);
                //}
            }
            totalLenght += 3;
            //Console.WriteLine(totalLenght);
            int wholeCables = totalLenght / 504;
            int unusedCable = totalLenght % 504;

            Console.WriteLine(wholeCables);
            Console.WriteLine(unusedCable);
        }
    }
}
