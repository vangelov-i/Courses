using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, double> prices = new Dictionary<string, double>() 
        {
            {"tomato", 1.90},
            {"cucumber", 2.15}
        };

        prices.Add("asd", 2.01);

        Console.WriteLine(prices["asd"]);



        string test = "   sdasd sad  asd dsf   fd";
        test = test.Remove(' ');
        Console.WriteLine(test);
        Console.WriteLine(test.Remove(' '));
    }
}