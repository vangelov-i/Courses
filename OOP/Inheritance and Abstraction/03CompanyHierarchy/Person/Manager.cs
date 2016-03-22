using System;
using System.Collections.Generic;

namespace _03CompanyHierarchy.Person
{
    using Interfaces;
    public class Manager : Employee, IManager
    {
        private List<Employee> Subordinates = new List<Employee>();

        public Manager(int id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {
        }

        public void AddSubordinate(Employee employee)
        {
            if (employee.Department != this.Department)
            {
                throw new ArgumentException("Subordinate must be in manager's department.");
            }
            this.Subordinates.Add(employee);
        }

        // THIS IS OPTIONAL
        public override string ToString()
        {
            string subOrdinatesList = string.Empty;
            foreach (var item in Subordinates)
            {
                subOrdinatesList += "\n" + item.FirstName + " " + item.LastName;
            }
            return base.ToString() + "Manager's subordinates list:" + subOrdinatesList;
        }

    }
}
