using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
// 16:42 - 17:07 -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);

            decimal euAlbums = decimal.Parse(Console.ReadLine());
            decimal euPrice = decimal.Parse(Console.ReadLine());
            decimal northAlbums = decimal.Parse(Console.ReadLine());
            decimal northPrice = decimal.Parse(Console.ReadLine());
            decimal southAlbums = decimal.Parse(Console.ReadLine());
            decimal southPrice = decimal.Parse(Console.ReadLine());
            decimal concerts = decimal.Parse(Console.ReadLine());
            decimal concertPrice = decimal.Parse(Console.ReadLine());

            
            decimal albumIncome = euAlbums * euPrice * 1.94m + northAlbums * northPrice * 1.72m + ((southAlbums * southPrice) / 332.74m);
            albumIncome = albumIncome * 0.65m;
            albumIncome = albumIncome * 0.80m;

            decimal concertsIncome = concerts * concertPrice * 1.94m;
            if (concertsIncome > 100000)
            {
                concertsIncome = concertsIncome * 0.85m;
            }

            if (albumIncome > concertsIncome)
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", albumIncome);
            }
            else
            {
                Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", concertsIncome);
            }
        }
    }
}