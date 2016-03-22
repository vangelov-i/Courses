namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;

    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string courseName, string teacherName, IList<string> students, string lab = null)
            : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }

        public LocalCourse(string courseName, string teacherName = null, string lab = null)
            : base(courseName, null)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                this.ValidateName(value, "Lab");

                this.lab = value;
            }
        }

        public override string ToString()
        {
            string result;
            if (this.Lab != null)
            {
                result = string.Format("{0}; Lab = {1} }}", base.ToString(), this.Lab);
            }
            else
            {
                result = base.ToString() + " }";
            }

            return result;
        }
    }
}