namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        private string name;

        private IList<string> students;

        private string teacherName;

        public Course(string courseName, string teacherName, IList<string> students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public Course(string courseName, string teacherName = null)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.ValidateName(value, "Name");

                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                this.ValidateName(value, "TeacherName");

                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Students list cannot be null or empty.");
                }

                this.students = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"{this.GetType().Name} {{ Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            if (this.Students.Count > 0)
            {
                result.Append("; Students = ");
                result.Append(this.GetStudentsAsString());
            }

            return result.ToString();
        }

        protected virtual void ValidateName(string value, string nameType)
        {
            if (value != null && value.Length < 3)
            {
                throw new ArgumentException("Name cannot be less than 3 letters.");
            }
        }

        private string GetStudentsAsString()
        {
            string result = "{ " + string.Join(", ", this.Students) + " }";

            return result;
        }
    }
}