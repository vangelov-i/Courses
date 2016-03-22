using System;

namespace _03CompanyHierarchy.Person
{
    using Interfaces;
    public abstract class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        public Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }


        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("ID can not be negative number");
                }
                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("First name can not be empty or null");
                }
                value = value.ToLower();
                value = value.Remove(0, 1).Insert(0, Char.ToUpper(value[0]).ToString());
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("First name can not be empty or null");
                }
                value = value.ToLower();
                value = value.Remove(0, 1).Insert(0, Char.ToUpper(value[0]).ToString());
                this.lastName = value;
            }
        }


        public override string ToString()
        {
            return "ID: " + this.Id + "\nFirst name: " + this.FirstName + "\nLast Name: " + this.LastName + "\n";
        }

    }
}
