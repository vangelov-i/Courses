namespace StudentSystem.ConsoleClient
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    using StudentSystem.Data;
    using StudentSystem.Data.Repositories;
    using StudentSystem.Model;

    public class StudentSystemConsoleClient
    {
        public static void Main()
        {
            var data = new StudentSystemData();

            //var firstStudentContactInfo = new ContactInfo()
            //{
            //    Email = "teTiMail@maila.bg",
            //    Number = "53453465352353",
            //    Skype = "sdfsdgdfgdfgd"
            //};

            #region filling some date
            //var courses = new[]
            //{
            //    new Course { Name = "EF Course" },
            //    new Course { Name = ".NET MVC" }
            //};

            //data.Courses.Add(courses[0]);
            //data.Courses.Add(courses[1]);
            //data.Courses.SaveChanges();

            //var firstStudent = new Student()
            //{
            //    FirstName = "Vani",
            //    LastName = "Banani",
            //    Age = 27,
            //    StudentStatus = StudentStatus.Online,
            //    ContactInfo = firstStudentContactInfo,
            //    Courses = courses
            //};

            //data.Students.Add(firstStudent);
            //data.Students.SaveChanges();

            //var secodnStudentContactInfo = new ContactInfo()
            //{
            //    Email = "asanGosho@goshomail.com"
            //};

            //var secondStudent = new Student()
            //{
            //    FirstName = "Goshkata",
            //    LastName = "Goshkov",
            //    Age = 23,
            //    ContactInfo = secodnStudentContactInfo,
            //    Courses = data.Courses.All().ToList()
            //};

            //data.Students.Add(secondStudent);
            //data.Students.SaveChanges();
            #endregion

            Console.WriteLine("Students:");
            foreach (var student in data.Students.All())
            {
                Console.WriteLine(student + Environment.NewLine);
            }

            Console.WriteLine("Courses:");
            foreach (var course in data.Courses.All())
            {
                Console.WriteLine(course);
            }
        }
    }
}