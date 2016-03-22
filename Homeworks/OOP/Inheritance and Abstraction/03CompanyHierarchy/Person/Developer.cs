using System.Collections.Generic;

namespace _03CompanyHierarchy.Person
{
    using Objects;
    public class Developer : RegularEmployee
    {

        private List<Project> Projects = new List<Project>();

        public Developer(int id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {
        }

        public void AddProject(Project project)
        {
            Projects.Add(project);
        }

        // THIS IS OPTIONAL
        public override string ToString()
        {
            string projectsList = string.Empty;
            foreach (var item in Projects)
            {
                projectsList += "\n" + item.Name;
            }
            return base.ToString() + "List of developer's project's names:" + projectsList;
        }

    }
}
