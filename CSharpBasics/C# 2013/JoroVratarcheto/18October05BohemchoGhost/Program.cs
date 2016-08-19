using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 17:50 - 18:20 -> 100!
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            List<long> listFloors = new List<long>();

            long mask = 1L;
            int ligtsOn = 0;
            while (true)
            {

                string stopOrFloor = (Console.ReadLine());

                if (stopOrFloor == "Stop, God damn it")
                {
                    break;
                }
                long floor = long.Parse(stopOrFloor);
                string[] visitRooms = Console.ReadLine().Split(' ');

                for (int i = 0; i < visitRooms.Length; i++)
                {
                    floor = floor ^ (mask << (int.Parse(visitRooms[i])));
                }
                for (int i = 0; i < 32; i++)
                {
                    if ((floor & (mask << i)) != 0)
                    {
                        ligtsOn++;
                    }
                }
                listFloors.Add(floor);

            }

            Console.WriteLine("Bohemcho left {0} lights on and his score is {1}", ligtsOn, listFloors.Sum());

        }
    }
}