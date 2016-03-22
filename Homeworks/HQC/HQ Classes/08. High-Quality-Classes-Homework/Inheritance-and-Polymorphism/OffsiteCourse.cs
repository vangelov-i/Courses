namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using System.Reflection.Emit;

    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string courseName, string teacherName, IList<string> students, string town = null)
            : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        public OffsiteCourse(string courseName, string teacherName = null, string town = null)
            : base(courseName, null)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                this.ValidateName(value, "Lab");

                this.town = value;
            }
        }

        public override string ToString()
        {
            string result;
            if (this.Town != null)
            {
                result = string.Format("{0}; Lab = {1} }}", base.ToString(), this.Town);

                return result;
            }

            result = base.ToString() + " }";

            return result;
        }
    }
}