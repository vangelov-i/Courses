using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dogge = new Dog("Groznio", 2, true);
            Dog koche = new Dog("Radka", 5, false);

            Tomcat mrycko = new Tomcat("Mrycko", 5);
            Tomcat dendi = new Tomcat("Dendi", 7);

            Kitten daisy = new Kitten("Daisy",4);
            Kitten stasy = new Kitten("Stasy",6);

            Frog prince = new Frog("Prince", 1, true);
            Frog princess = new Frog("Princess", 1, false);

            Animal[] animals = { dogge, koche, mrycko, dendi, daisy, stasy, prince, princess };

            animals.Where(x => x is Dog).Average(x => x.Age);


            double dogsAvgAge = animals.Where(x => x is Dog).Average(x => x.Age);
            double tomcatsAvgAge = animals.Where(x => x is Tomcat).Average(x => x.Age);
            double kittensAvgAge = animals.Where(x => x is Kitten).Average(x => x.Age);
            double frogsAvgAge = animals.Where(x => x is Frog).Average(x => x.Age);

            Console.Write(dogsAvgAge + "\n" + tomcatsAvgAge + "\n" + kittensAvgAge + "\n" + frogsAvgAge + "\n");
        }
    }
}
