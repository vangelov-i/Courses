namespace TelerikAcademy_EF_Performance
{
    using System;
    using System.Linq;

    class EntityFrameworkPerformancePlayground
    {
        static void Main(string[] args)
        {
            var telerikDbContext = new TelerikAcademyEntities();

            int count = 0;
            //var employees = telerikDbContext.Employees;
            var employees = telerikDbContext.Employees.Select(e => new
            {
                Name = e.FirstName + " " + e.LastName,
                Department = e.Department.Name,
                Town = e.Address.Town.Name
            });

            foreach (var employee in employees)
            {
                Console.Write(count++ + " ");
                Console.WriteLine(
                    "Name: {0}{1}Department: {2}{1}Town: {3}",
                    employee.Name,
                    Environment.NewLine,
                    employee.Department,
                    employee.Town);
            }
        }
    }
}