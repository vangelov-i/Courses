using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvlTreeLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new AvlTree<int>();
            tree.Add(20);
            tree.Add(12);
            tree.Add(25);
            tree.Add(8);
            tree.Add(17);
            tree.Add(26);
            tree.Add(4);
            tree.Add(10);
            tree.Add(15);
            tree.Add(19);

            tree.Add(11);

            // tree.Add(65);
            //tree.Add(70);
            Console.WriteLine();
        }
    }
}
