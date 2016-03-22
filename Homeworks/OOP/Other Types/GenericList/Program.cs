using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main()
        {
            try
            {
                GenericList<int> list = new GenericList<int>();

                //Console.WriteLine(list.Min());  // list is empty catched exception

                list.AddElement(1);
                list.AddElement(2);
                list.AddElement(3);
                list.AddElement(4);
                list.AddElement(5);
                list.AddElement(6);
                list.AddElement(7);
                list.AddElement(8);
                list.AddElement(9);
                list.AddElement(10);
                list.AddElement(11);
                list.AddElement(12);
                list.AddElement(13);
                list.AddElement(14);
                list.AddElement(15);
                list.AddElement(16);
                list.AddElement(17); // the list resizes here
                list.AddElement(18);
                list.Insert(-1, 0); // 1st param is the element, second param is the index

                Console.WriteLine("Min: " + list.Min());
                Console.WriteLine("Max: " + list.Max());
                Console.WriteLine("Index of -1: " + list.IndexOf(-1));
                Console.WriteLine("Trying to reach index of 100: " + list.IndexOf(100));
                Console.WriteLine("list.ToString():\n" + list);
                Console.WriteLine("List countains 20: " + list.Contains(20));
                Console.WriteLine("List contains 10: " + list.Contains(10));
                Console.WriteLine("clearing the list");
                Console.WriteLine(list.Version());
                list.Clear();
                Console.WriteLine("Trying to print the empty list:");
                Console.WriteLine(list);
            }
            catch (InvalidOperationException ioe)
            {

                Console.WriteLine(ioe.Message);
            }

        }
    }
}
