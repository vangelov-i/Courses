namespace StudentSystem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;

    public class Course
    {
        private ICollection<Student> students;
        private ICollection<Homework> homeworks;

        public Course()
        {
            this.students = new HashSet<Student>();
            this.homeworks = new HashSet<Homework>();
            this.Start = DateTime.Now;
            this.End = DateTime.Now.AddDays(1);
        } 

        public int CourseId { get; set; }

        [MaxLength(100)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public virtual ICollection<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get
            {
                return this.homeworks;
            }
            set
            {
                this.homeworks = value;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "-------------{0}Course name: {1}{0}Starts: {2}{0}Ends: {3}",
                Environment.NewLine,
                this.Name,
                this.Start,
                this.End);
        }
    }
}