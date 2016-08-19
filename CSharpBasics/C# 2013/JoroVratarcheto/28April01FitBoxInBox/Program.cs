using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 100 tochki  za 35 min
namespace _28April01FitBoxInBox
{
    class Program
    {
        static void Main(string[] args)
        {
            int w1 = int.Parse(Console.ReadLine());
            int h1 = int.Parse(Console.ReadLine());
            int d1 = int.Parse(Console.ReadLine());

            int w2 = int.Parse(Console.ReadLine());
            int h2 = int.Parse(Console.ReadLine());
            int d2 = int.Parse(Console.ReadLine());

            int[] smallerBox = { w1, h1, d1 };
            int[] biggerBox = { w2, h2, d2 };
            int[] duplicateBigger = { w2, h2, d2 };

            int smallerMax = smallerBox.Max();
            int biggerMax = biggerBox.Max();

            if (smallerMax > biggerMax)
            {
                biggerBox = smallerBox;
                smallerBox = duplicateBigger;
            }


            for (int i = 0; i < 3; i++)
            {
                for (int i1 = 0; i1 < 3; i1++)
                {
                    for (int i2 = 0; i2 < 3; i2++)
                    {
                        if (smallerBox[0] < biggerBox[i] && smallerBox[1] < biggerBox[i1] && smallerBox[2] < biggerBox[i2]  &&
                            biggerBox[i] != biggerBox[i1] && biggerBox[i] != biggerBox[i2] && biggerBox[i1] != biggerBox[i2])
                        {
                            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",smallerBox[0],smallerBox[1],smallerBox[2],biggerBox[i],biggerBox[i1],biggerBox[i2]);
                        }
                    }
                }
            }


        }
    }
}
