namespace _03CompanyHierarchy.Person
{
    using System;

    using _03CompanyHierarchy.Interfaces;

    public abstract class Person : IPerson
    {
        private string firstName;

        private int id;

        private string lastName;

        protected Person(int id, string firstName, string lastName)
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "First name can not be empty or null");
                }

                value = value.Remove(0, 1).Insert(0, char.ToUpper(value[0]).ToString()).ToLower();

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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "First name can not be empty or null");
                }

                value = value.Remove(0, 1).Insert(0, char.ToUpper(value[0]).ToString()).ToLower();

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return "ID: " + this.Id + "\nFirst name: " + this.FirstName + "\nLast Name: " + this.LastName + "\n";
        }
    }
}