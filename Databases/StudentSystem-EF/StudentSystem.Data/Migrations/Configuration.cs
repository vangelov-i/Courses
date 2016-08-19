namespace StudentSystem.Data.Migrations
{
    using System.Data.Entity;
    using System.Data.Entity.Migrations;

    using StudentSystem.Model;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            
            this.ContextKey = "StudentSystem.Data.StudentSystemDbContext";
        }

        protected override void Seed(StudentSystemDbContext context)
        {
            //context.Students.Add(new Student()
            //{
            //    FirstName = "Goshkata",
            //    LastName = "Goshkov",
            //    Age = 23,
            //    Email = "asanGosho@goshomail.com"
            //});
        }
    }
}