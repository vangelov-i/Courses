using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherTypesExercise
{
    class TestCustomList
    {
        static void Main()
        {
            try
            {
                CustomList<int> list = new CustomList<int>();

                list.AddElement(1);
                list.AddElement(2);
                list.AddElement(3);
                list.AddElement(4);
                list.AddElement(5);
                list.AddElement(6);
                list.AddElement(6);
                list.AddElement(6);
                list.AddElement(6);
                list.AddElement(6);
                list.AddElement(6);
                list.AddElement(15);
                list.AddElement(6);
                list.AddElement(6);
                list.AddElement(6);
                list.AddElement(6);
                list.AddElement(6);
                //list.AddElement(6);

                Console.WriteLine(list.Min());
                Console.WriteLine(list.Max());
                Console.WriteLine(list.IndexOf(15));
            }
            catch (InvalidOperationException ioe)
            {

                Console.WriteLine(ioe.Message);
            }

        }
    }
}
