using System;

namespace _03CompanyHierarchy.Person
{
    using Interfaces;

    // NOT SURE IF THIS CLASS SHOULD BE ABSTRACT...
 
    public class Employee : Person, IEmployee
    {
        private decimal salary;

        public Employee(int id, string firstName, string lastName, decimal salary, Department department)
            : base (id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("Salary can not be a negative number.");
                }
                this.salary = value;
            }
        }

        public Department Department { get; set; }
        //{
        //    get
        //    {
        //        return this.department;
        //    }
        //    set
        //    {
        //        value = value.ToLower().Trim();
        //        if (value != "production" && value != "accounting" && value != "sales" && value != "marketing")
        //        {
        //            throw new ArgumentException(string.Format(@"Department can only be ""Production"",""Accounting"", ""Sales"" or ""Marketing""."));
        //        }
        //        value = value.Remove(0,1).Insert(0, Char.ToUpper(value[0]).ToString());
        //        this.department = value;
        //    }
        //}


        public override string ToString()
        {
            return base.ToString() + "Salary: " + this.Salary + "\nDepartment: " + this.Department + "\n";
        }

    }
}
