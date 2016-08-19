using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6FourDigitNumber
{
    class P6FourDigitNumber
    {
        static void Main()
        {
            start:
            Console.Write("Please enter a four digit dumber: ");
            int number = int.Parse(Console.ReadLine());
            int firstDigNum = (number / 1000) % 10;
            int secondDigNum = (number / 100) % 10;
            int thirdDigNum = (number / 10) % 10;
            int fourthDigNum = number % 10;
            Console.WriteLine("sum of digits: {0}",firstDigNum + secondDigNum + thirdDigNum + fourthDigNum);
            Console.WriteLine("reversed: {0}{1}{2}{3}",fourthDigNum, thirdDigNum, secondDigNum, firstDigNum);
            Console.WriteLine("last digit in front: {0}{1}{2}{3}",fourthDigNum,firstDigNum,secondDigNum,thirdDigNum);
            Console.WriteLine("second and third digits exchanged: {0}{1}{2}{3}",firstDigNum,thirdDigNum,secondDigNum, fourthDigNum);
            goto start;

            //way too ugly way to solve this problem ... :D will check it  again later
        }
    }
}
