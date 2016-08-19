using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Animals
{
    public class Frog : Animal
    {
        public Frog(string name, int age, bool isMale)
            : base (name, age, isMale)
        {
        }

        public override void ProduceSound(Animal animal)
        {
            Console.WriteLine("The frog {0} says: ribbit!", this.Name);
        }
    }
}
