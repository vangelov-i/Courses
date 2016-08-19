/* 
    If the class gets too big or there are too many models/tables,
    it's better to make another DbContext class and logicaly split the functionality
    where it belongs ... just HQC principles
*/
namespace StudentSystem.Data
{
    using System.Data.Entity;

    using StudentSystem.Data.Contracts;
    using StudentSystem.Data.Migrations;
    using StudentSystem.Model;

    public class StudentSystemDbContext : DbContext, IStudentSystemDbContext
    {
        private const string DefaultConnectionStringName = "StudentSystem";

        public StudentSystemDbContext()
            : base(DefaultConnectionStringName)
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());

        }

        public IDbSet<Student> Students { get; set; }

        public IDbSet<Course> Courses { get; set; }

        public IDbSet<Homework> Homeworks { get; set; }

        public IDbSet<Log> Logs { get; set; }

        public IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}