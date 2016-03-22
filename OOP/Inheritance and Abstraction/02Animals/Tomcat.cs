using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Animals
{
    public class Tomcat : Cat
    {
        private const bool DefaultGenderMale = true;

        public Tomcat(string name, int age)
            : base (name, age, DefaultGenderMale)
        {
        }

        public override void ProduceSound(Animal animal)
        {
            Console.WriteLine("The tomcat {0} says: meoow.", this.Name);
        }
    }
}
