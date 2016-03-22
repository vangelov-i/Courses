using _01Point3D;
using System;

namespace _03Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            while (line[0] != "End")
            {
                switch (line[0])
                {
                    case "SavePath":
                        line = Console.ReadLine().Split(' ');
                        Path3D path = new Path3D();
                        while (Char.IsDigit(line[0][0]))
                        {
                            path.AddPoint3D(new Point3D(double.Parse(line[0]), double.Parse(line[1]), double.Parse(line[2])));
                            line = Console.ReadLine().Split(' ');
                        }
                        Storage.SavePath(path);
                        break;
                    case "LoadPath":
                        Storage.LoadPath();
                        line = Console.ReadLine().Split(' ');
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
