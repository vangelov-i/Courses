using System;
using System.IO;

namespace _03Paths
{
    public static class Storage
    {
        // a class with two static methods - save and load 
        private static int counter = 0;

        public static void SavePath(Path3D path)
        {
            string filePath = string.Format(@"C:\Users\Iliyan\Dropbox\Fundamentals [OOP]\HM\Static Members and Name Spaces\" +
                "{0}.txt", (counter.ToString()));
            File.WriteAllText(filePath, string.Join(Environment.NewLine, path.Points3D()));
            counter++;
        }

        public static void LoadPath()
        {            
            //int index = path.Points3D().FindIndex(f => (f.X == point3D.X) && (f.Y == point3D.Y) && (f.Z == point3D.Z));
            string filePath = string.Format(@"C:\Users\Iliyan\Dropbox\Fundamentals [OOP]\HM\Static Members and Name Spaces\" +
                "{0}.txt", (counter - 1).ToString());
            StreamReader reader = new StreamReader(filePath);
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                }
            }
        }

    }
}
