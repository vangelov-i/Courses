using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Animals
{
    public class Kitten : Cat
    {
        private const bool DefaultGenderFemale = false;

        public Kitten(string name, int age)
            : base (name, age, DefaultGenderFemale)
        {
        }

        public override void ProduceSound(Animal animal)
        {
            Console.WriteLine("The kitten {0} says: meoow.", this.Name);
        }
    }
}
