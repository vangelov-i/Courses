﻿
using System;public class Student : IComparable<Student>
{
    public Student(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int CompareTo(Student other)
    {
        if (this.LastName != other.LastName)
        {
            return this.LastName.CompareTo(other.LastName);
        }

        return this.FirstName.CompareTo(other.FirstName);
    }

    public override string ToString()
    {
        return this.FirstName + " " + this.LastName;
    }
}