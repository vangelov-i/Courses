using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Animals
{
    
    public abstract class Animal : ISoundProducible
    {
        private string name;
        private int age;
        private bool isMale;

        public Animal(string name, int age, bool isMale)
        {
            this.Name = name;
            this.Age = age;
            this.IsMale = isMale;
        }

        public string Name 
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age 
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public bool IsMale 
        {
            get { return this.isMale; }
            set { this.isMale = value; }
        }


        public abstract void ProduceSound(Animal animal);

    }
}
