namespace StudentSystem.Data.Repositories
{
    using System.Linq;

    using StudentSystem.Data.Contracts;
    using StudentSystem.Model;

    public class StudentsRepository : GenericRepository<Student>
    {
        public StudentsRepository(IStudentSystemDbContext studentSystemDbContext)
            : base(studentSystemDbContext)
        {
        }

        public IQueryable<Student> AllAssistants()
        {
            return this.Search(s => s.Trainees.Any());
        } 
    }
}