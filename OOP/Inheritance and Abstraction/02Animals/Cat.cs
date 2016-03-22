using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Animals
{
    public abstract class Cat : Animal
    {
        public Cat(string name, int age, bool isMale)
            : base (name, age, isMale)
        {
        }

    }
}
