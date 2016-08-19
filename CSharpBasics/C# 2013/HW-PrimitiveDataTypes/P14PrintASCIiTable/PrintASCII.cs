using System;
using System.Text;

namespace P14PrintASCIiTable
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine(Convert.ToChar(i));
            }
        }
    }
}
