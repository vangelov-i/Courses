using System;

namespace _01Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", 24);
            Person ivanka = new Person("Ivanka", 11, "ivanka@abv.bg");

            Console.WriteLine(pesho.ToString());
            Console.WriteLine(ivanka.ToString());

        }
    }
}
