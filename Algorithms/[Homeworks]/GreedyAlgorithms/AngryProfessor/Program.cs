using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder result = new StringBuilder();
        int testsCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < testsCount; i++)
        {
            int[] studentsParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] studentsArrivalTime = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int presentStudents = studentsParams[0];
            int threashold = studentsParams[1];

            foreach (var arrivalTime in studentsArrivalTime)
            {
                if (arrivalTime > 0)
                {
                    presentStudents--;
                }
            }

            if (presentStudents < threashold)
            {
                result.AppendLine("YES");
            }
            else
            {
                result.AppendLine("NO");
            }
        }

        Console.Write(result);
    }
}