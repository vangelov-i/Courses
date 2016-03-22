using System;

namespace _03CompanyHierarchy
{
    using Objects;
    using Person;

    class Program
    {
        static void Main(string[] args)
        {
            Sale refrigerator = new Sale("Mraz", new DateTime(2015,11,24), 1100);
            Sale tv = new Sale("Opera", new DateTime(2015,11,23), 100);

            Project refrigeratorSoft = new Project("Ref. Soft", new DateTime(2015,11,25), "Pretty cool software", "open");
            Project tvSoft = new Project("TV Soft", new DateTime(2015,11,26), "Awesome software", "open");

            SalesEmployee goshko = new SalesEmployee(2201, "Gosho", "Kirkata", 1000, Department.Sales);
            SalesEmployee toshko = new SalesEmployee(2202, "Tosho", "Arabiqta", 1050, Department.Sales);

            goshko.AddSale(refrigerator);
            toshko.AddSale(tv);

            Developer sharo = new Developer(3301, "Sharo", "Rijaviq", 3000, Department.Production);
            Developer djeki = new Developer(3302, "Djeki", "Djekichana", 3050, Department.Production);

            sharo.AddProject(refrigeratorSoft);
            djeki.AddProject(tvSoft);

            Manager stoiko = new Manager(1135, "Stoiko", "Stoikov", 4000, Department.Sales);
            Manager johnny = new Manager(1136, "Johnny", "Johnson", 4500, Department.Production);

            stoiko.AddSubordinate(goshko);
            stoiko.AddSubordinate(toshko);

            johnny.AddSubordinate(sharo);
            johnny.AddSubordinate(djeki);


            Employee[] employeesList = { stoiko, johnny, goshko, toshko, sharo, djeki };

            foreach (var item in employeesList)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }

        }
    }
}
