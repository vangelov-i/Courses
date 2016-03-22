using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _01CustomLINqExtensionMethods
{
    class Program
    {
        static void Main()
        {
            var nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var filterCollection = nums.WhereNot(x => x % 2 == 0);
            Console.WriteLine(string.Join(", ", filterCollection));

            var students = new List<Student> 
            {
                //new Student {Name = "Pesho", Grade = 3},
                //new Student {Name = "Gosho", Grade = 2},
                //new Student {Name = "Mariika", Grade = 7},
                //new Student {Name = "Stamat", Grade = 5}
            };

            Console.WriteLine(students.Max(student => student.Grade));
            

        }
    }

    public class Student
    {
        public string Name { get; set; }

        public int Grade { get; set; }
    }
}
