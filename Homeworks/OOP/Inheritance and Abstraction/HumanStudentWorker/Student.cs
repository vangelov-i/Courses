﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base (firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber 
        {
            get { return this.facultyNumber; }
            set {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new IndexOutOfRangeException("Faculty number must be 5-10 characters long.");
                }
                this.facultyNumber = value; }
        }

    }
}
