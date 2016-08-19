namespace StudentSystem.Data.Contracts
{
    using StudentSystem.Data.Repositories;
    using StudentSystem.Model;

    public interface IStudentSystemData
    {
        IGenericRepository<Course> Courses { get; }

        IGenericRepository<Homework> Homeworks { get; }

        StudentsRepository Students { get; }
    }
}