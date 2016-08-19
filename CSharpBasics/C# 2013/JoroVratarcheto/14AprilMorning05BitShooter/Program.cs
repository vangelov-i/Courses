using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//23:55 - 00:30
namespace _14AprilMorning05BitShooter
{
    class Program
    {
        static void Main(string[] args)
        {


            ulong field = ulong.Parse(Console.ReadLine());
            string firstShot = Console.ReadLine();
            string[] s1 = firstShot.Split(' ');
            string secondShot = Console.ReadLine();
            string[] s2 = secondShot.Split(' ');
            string thirdShot = Console.ReadLine();
            string[] s3 = thirdShot.Split(' ');

            int center1 = Convert.ToInt32(s1[0]);
            int size1 = Convert.ToInt32(s1[1]);

            // FIRST SHOT
            int killBits1Start = center1 - size1 / 2;
            int corrector1 = 0;

            if (killBits1Start < 0)
            {
                size1 = size1 + killBits1Start;
                killBits1Start = 0;

            }
            if (center1 + size1 / 2 > 63)
            {
                corrector1 = (center1 + size1 / 2) - 63; 
            }

            // SECOND SHOT
            int center2 = Convert.ToInt32(s2[0]);
            int size2 = Convert.ToInt32(s2[1]);
            int killBits2Start = center2 - size2 / 2;
            int corrector2 = 0;

            if (killBits2Start < 0)
            {
                size2 = size2 + killBits2Start;
                killBits2Start = 0;
            }
            if (center2 + size2 / 2 > 63)
            {
                corrector2 = (center2 + size2 / 2) - 63;
            }

            // THIRD SHOT
            int center3 = Convert.ToInt32(s3[0]);
            int size3 = Convert.ToInt32(s3[1]);
            int killBits3Start = center3 - size3 / 2;
            int corrector3 = 0;

            if (killBits3Start < 0)
            {
                size3 = size3 + killBits3Start;
                killBits3Start = 0;
            }
            if (center3 + size3 / 2 > 63)
            {
                corrector3 = (center3 + size3 / 2) - 63;
            }

            //5 SHOOTING  1st
            if ((killBits1Start == 0 && size1 > 63) || (killBits2Start == 0 && size2 > 63) || (killBits3Start == 0 && size3 > 63))
            {
                Console.WriteLine("left: 0");
                Console.WriteLine("right: 0");
            }
            else
            {
                //long mask1 = (long)((Math.Pow(2, (size1 - corrector1)) - 1)) << killBits1Start;
                //Console.WriteLine(mask1);

                field = field & ~((ulong)(Math.Pow(2, (size1 - corrector1)) - 1) << killBits1Start);

                //long mask2 = (long)(Math.Pow(2, (size2 - corrector2)) - 1) << killBits2Start;
                //Console.WriteLine(Convert.ToString(mask2, 2));
                field = field & ~((ulong)(Math.Pow(2, (size2 - corrector2)) - 1) << killBits2Start);

                //long mask3 = (long)(Math.Pow(2, (size3 - corrector3)) - 1) << killBits3Start;
                //Console.WriteLine(Convert.ToString(mask3, 2));
                field = field & ~((ulong)(Math.Pow(2, (size3 - corrector3)) - 1) << killBits3Start);

                string binary = Convert.ToString((long)field, 2).PadLeft(64, '0');
                string left = string.Empty;
                string right = string.Empty;
                for (int i = 0; i < 64; i++)
                {
                    if (i < 32)
                    {
                        left += binary[i].ToString();
                    }
                    else
                    {
                        right += binary[i].ToString();
                    }
                }

                int counterLeft = 0;

                foreach (var digit in left)
                {
                    if (digit == '1')
                    {
                        counterLeft++;
                    }
                }

                int counterRight = 0;
                foreach (var digit in right)
                {
                    if (digit == '1')
                    {
                        counterRight++;
                    }
                }

                Console.WriteLine("left: {0}", counterLeft);
                Console.WriteLine("right: {0}", counterRight);
            }
        }
    }
}
