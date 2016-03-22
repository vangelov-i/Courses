namespace _01ClassStudent
{
    using System;
    using System.Linq;

    class GroupStudents
    {
        static void Main()
        {
            #region Problem 02

            Console.WriteLine("Problem 02:");

            var students = StudentsData.Students;

            var group1 = from student in students
                         where student.GroupNumber == "grupa 1"
                         group student by student.GroupNumber
                         into grouptwo
                         select grouptwo;

            foreach (var group in group1)
            {
                Console.Write("{0} -> ", group.Key);
                Console.WriteLine(string.Join(", ", group));
            }

            var group2 = students.Where(s => s.GroupNumber == "grupa 2");
            group2 = group2.OrderBy(s => s.FirstName);

            Console.WriteLine("grupa 2 -> " + string.Join(", ", group2));

            #endregion

            #region Problem 03

            Console.WriteLine("{0}Problem 03:", Environment.NewLine);
            students = StudentsData.Students;
            students = students.Where(s => s.FirstName.CompareTo(s.LastName) == -1).ToList();

            Console.WriteLine(
                "Students who's first name is alphabetically before their last name:{0}{1}",
                Environment.NewLine,
                string.Join(", ", students));

            #endregion

            #region Problem 04
            Console.WriteLine("{0}Problem 04:", Environment.NewLine);

            students = StudentsData.Students;
            var groupedAge = from student in students
                             where student.Age > 18 && student.Age < 24
                             group student by student
                             into ageGroup
                             select new { ageGroup.Key.FirstName, ageGroup.Key.LastName, ageGroup.Key.Age };

            Console.WriteLine("Students by Age (18 < age < 24):");
            Console.WriteLine(string.Join("\n", groupedAge));

            #endregion

            #region Problem 05
            Console.WriteLine("{0}Problem 05:", Environment.NewLine);
            students = StudentsData.Students;
            students = students.OrderBy(s => s.FirstName).ThenBy(s => s.LastName).ToList();
            Console.WriteLine("Students sorted first by first name and then by last name:");
            Console.WriteLine(string.Join("\n", students));
            #endregion

            #region Problem 06

            Console.WriteLine("{0}Problem 06:", Environment.NewLine);

            students = StudentsData.Students;

            var studentsWithAbvEmail = students.Where(s => s.Email.Substring(s.Email.IndexOf("@") + 1) == "abv.bg").ToList();

            Console.WriteLine("Students who's email is @abv.bg:");
            Console.WriteLine(string.Join(", ", studentsWithAbvEmail));

            #endregion

            #region Problem 07

            Console.WriteLine("{0}Problem 07:", Environment.NewLine);

            students = StudentsData.Students;

            var studentsWithStationaryPhoneInSofia = students.Where(s => s.Phone.Substring(0, 5) == "+3592").ToList();

            Console.WriteLine("Students who's stationary phone is in Sofia:");
            Console.WriteLine(string.Join(", ", studentsWithStationaryPhoneInSofia));

            #endregion

            #region Problem 08

            Console.WriteLine("{0}Problem 08:", Environment.NewLine);

            students = StudentsData.Students;

            var excellentStudents = from student in students
                                    where student.Marks.Contains(6)
                                    group student.Marks by student
                                    into gradesGroup
                                    select new
                                    {
                                        Fullname = gradesGroup.Key.ToString(),
                                        Marks = string.Join(", ", gradesGroup.Key.Marks)
                                    };

            Console.WriteLine("Students who have at least one excellent grade (6):");
            Console.WriteLine(string.Join("\n", excellentStudents));

            #endregion

            #region Problem 09

            Console.WriteLine("{0}Problem 09:", Environment.NewLine);

            students = StudentsData.Students;

            var poorMarkStudents = from student in students
                                   where student.Marks.GroupBy(m => m).Any(g => g.Count() > 1 && g.Key == 2)
                                   group student.Marks by student
                                   into gradesGroup
                                   select new
                                   {
                                       Fullname = gradesGroup.Key.ToString(),
                                       Marks = string.Join(", ", gradesGroup.Key.Marks)
                                   };

            Console.WriteLine("Students who have exactly two poor grades (2):");
            Console.WriteLine(string.Join("\n", poorMarkStudents));

            #endregion

            #region Problem 10

            Console.WriteLine("{0}Problem 10:", Environment.NewLine);

            students = StudentsData.Students;

            var students2014 = students.
                Where(s => s.FacultyNumber.Substring(4) == "14").
                GroupBy(grades => grades).
                Select(group => new
                {
                    Fullname = group.Key.ToString(),
                    Marks = string.Join(", ", group.Key.Marks)
                });

            Console.WriteLine("Marks of students who have enrolled in 2014:");
            Console.WriteLine(string.Join("\n", students2014));

            #endregion
        }
    }
}