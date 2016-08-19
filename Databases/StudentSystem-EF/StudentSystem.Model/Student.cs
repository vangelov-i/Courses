namespace StudentSystem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;

    using StudentSystem.Model.CustomAttributes;

    public class Student
    {
        private ICollection<Course> courses;
        private ICollection<Homework> homeworks;
        private ICollection<Student> trainees;

        public Student()
        {
            this.Id = Guid.NewGuid();
            this.courses = new HashSet<Course>();
            this.homeworks = new HashSet<Homework>();
            this.trainees = new HashSet<Student>();
            this.ContactInfo = new ContactInfo();
        }

        public Guid Id { get; set; }

        [MinLength(2)]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [MinLength(2)]
        [MaxLength(20)]
        public string LastName { get; set; }

        [MinValue(3)]
        [MaxValue(100)]
        public int Age { get; set; }

        public ContactInfo ContactInfo { get; set; }

        public StudentStatus StudentStatus { get; set; }

        //public Guid AssistantId { get; set; }

        public virtual Student Assistant { get; set; }

        [InverseProperty("Assistant")]
        public virtual ICollection<Student> Trainees
        {
            get
            {
                return this.trainees;
            }
            set
            {
                this.trainees = value;
            }
        }

        public virtual ICollection<Course> Courses
        {
            get
            {
                return this.courses;
            }
            set
            {
                this.courses = value;
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
                "Student ID: {0}{1}Full Name: {2} {3}{1}Age: {4}{1}{5}",
                this.Id,
                Environment.NewLine,
                this.FirstName,
                this.LastName,
                this.Age,
                this.ContactInfo);
        }
    }
}