
namespace _03CompanyHierarchy.Interfaces
{
    using Person;
    interface IEmployee
    {
        decimal Salary { get; set; }

        Department Department { get; set; }


    }
}
