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
            //tree.Add(50);
            //tree.Add(25);
            //tree.Add(75);
            //tree.Add(65);
            //tree.Add(70);
            //tree.Add(234);
            //tree.Add(116);
            //tree.Add(6);
            //tree.Add(18);
            //tree.Add(71);
            //tree.Add(90);
            //tree.Add(120);
            //tree.Add(300);

            int[] nodes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            foreach (var node in nodes)
            {
                tree.Add(node);
            }

            int[] rangeParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = rangeParams[0];
            int end = rangeParams[1];

            Console.WriteLine(string.Join(" ", tree.Range(start, end)));
            Console.WriteLine(tree.getRangeCounter);
            // tree.Add(65);
            //tree.Add(70);
            Console.WriteLine();
        }
    }
}
