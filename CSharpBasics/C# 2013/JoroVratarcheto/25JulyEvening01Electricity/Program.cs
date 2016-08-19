using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//20:15 - 20:35
class Program
{
    static void Main(string[] args)
    {
        checked
        {


            int floors = int.Parse(Console.ReadLine());
            int flatsPerFloor = int.Parse(Console.ReadLine());
            string hour = Console.ReadLine();
            string strTime = string.Empty;
            if (hour.Length == 4)
            {
                strTime = hour[0].ToString() + hour[2] + hour[3];
            }
            else
            {
                strTime = hour[0].ToString() + hour[1] + hour[3] + hour[4];
            }

            if (strTime[0] == '0')
            {
            }
            int time = int.Parse(strTime);
            int flats = floors * flatsPerFloor;

            double lamps = 100.53;
            double pc = 125.9;
            double consuption = 0d;

            if (time >= 1400 && time < 1900)
            {
                consuption = lamps * 2 * flats;
                consuption += pc * 2 * flats;
            }
            else if (time >= 1900 && time < 2400)
            {
                consuption = lamps * 7 * flats;
                consuption += pc * 6 * flats;
            }
            else if (time >= 0000 && time < 0900)
            {
                consuption = lamps * flats + pc * 8 * flats;
            }
            Console.WriteLine((long)consuption + " Watts");

        }
    }
}