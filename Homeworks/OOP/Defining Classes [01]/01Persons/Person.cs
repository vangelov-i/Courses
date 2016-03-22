using System;
using System.Linq;

namespace _01Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int ages, string email)
        {
            this.Name = name;
            this.Age = ages;
            this.Email = email;
        }

        public Person(string name, int age) : this (name, age, null)
        {
        }

        public string Name { get { return this.name; } set { this.name = value; } }
        public int Age 
        {
            get
            {
                return this.age ;
            }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age", "Age should be in the range 0 < Age <= 100");
                }
                this.age = value;

            }
        }

        public string Email 
        {
            get
            {
               return this.email ;
            }
            set
            {
               this.email = value ;
               if (value != null && !value.Contains('@'))
               {
                   throw new ArgumentException("Email must be a valid Email address", "Email");
               }
            }
        }

        public override string ToString()
        {
            return string.Format(
                "I am {0}, aged {1}. Emaail: {2}", 
                this.name, this.age, this.email ?? "no email");
        }

    }
}
