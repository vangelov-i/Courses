using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//15:50 - 16:25  66/100
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            decimal n = int.Parse(Console.ReadLine());
            decimal Price = 0M;
            decimal packs = 0M;
            decimal booksPerPack = 0M;
            decimal books = 0M;
            decimal totalBooks = 0M;
            decimal initialOrderPrice = 0M;
            decimal finalOrderPrice = 0M;
            decimal finalTotalPrice = 0M;
            for (int i = 0; i < n; i++)
            {
                packs = decimal.Parse(Console.ReadLine());
                booksPerPack = decimal.Parse(Console.ReadLine());
                Price = decimal.Parse(Console.ReadLine());
                books = booksPerPack * packs;
                totalBooks += books;
                initialOrderPrice = books * Price;

                if (packs < 10)
                {
                    finalOrderPrice = initialOrderPrice;
                }
                else if (packs >= 10 && packs < 20)
                {
                    finalOrderPrice = initialOrderPrice * 0.95M;
                }
                else if (packs < 30)
                {
                    finalOrderPrice = initialOrderPrice * 0.94M;
                }
                else if (packs < 40)
                {
                    finalOrderPrice = initialOrderPrice * 0.93M;
                }
                else if (packs < 50)
                {
                    finalOrderPrice = initialOrderPrice * 0.92M;

                }
                else if (packs < 60)
                {
                    finalOrderPrice = initialOrderPrice * 0.91M;

                }
                else if (packs < 70)
                {
                    finalOrderPrice = initialOrderPrice * 0.90M;

                }
                else if (packs < 80)
                {
                    finalOrderPrice = initialOrderPrice * 0.89M;

                }
                else if (packs < 90)
                {
                    finalOrderPrice = initialOrderPrice * 0.88M;

                }
                else if (packs < 100)
                {
                    finalOrderPrice = initialOrderPrice * 0.87M;

                }
                else if (packs < 110)
                {
                    finalOrderPrice = initialOrderPrice * 0.86M;

                }
                else if (packs >= 110)
                {
                    finalOrderPrice = initialOrderPrice * 0.85M;

                }
                finalTotalPrice += finalOrderPrice;
            }
            Console.WriteLine((int)totalBooks);
            Console.WriteLine("{0:F2}", finalTotalPrice);

        }
    }
}
