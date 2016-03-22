﻿namespace _01ClassStudent
{
    using System.Collections.Generic;

    // Problem 01
    public class Student
    {
        public Student(
            string firstName,
            string lastName,
            int age,
            string facultyNumber,
            string phone,
            string email,
            IList<int> marks,
            string groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string FacultyNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public IList<int> Marks { get; set; }

        public string GroupNumber { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}