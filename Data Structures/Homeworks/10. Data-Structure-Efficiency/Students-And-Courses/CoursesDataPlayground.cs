using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

using Wintellect.PowerCollections;

class CoursesDataPlayground
{
    static void Main()
    {
        var coursesData = new SortedDictionary<string, OrderedBag<Student>>();
        var studentsInputReader = new StreamReader("../../students.txt");
        using (studentsInputReader)
        {
            string currentLine = studentsInputReader.ReadLine();
            while (currentLine != null)
            {
                string[] lineParams = currentLine.Split(
                    new[] { ' ', '|' },
                    StringSplitOptions.RemoveEmptyEntries);

                string firstName = lineParams[0];
                string lastName = lineParams[1];
                string courseName = lineParams[2];

                var studentToAdd = new Student(firstName, lastName);

                if (! coursesData.ContainsKey(courseName))
                {
                    coursesData[courseName] = new OrderedBag<Student>();
                }

                coursesData[courseName].Add(studentToAdd);

                currentLine = studentsInputReader.ReadLine();
            }
        }

        foreach (var courseStudentsPair in coursesData)
        {
            Console.WriteLine(
                "{0}: {1}", 
                courseStudentsPair.Key, 
                string.Join(", ", courseStudentsPair.Value));
        }
    }
}