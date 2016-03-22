using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LaptopShop
{
    class Program
    {
        static void Main()
        {
            Battery toshiba = new Battery("qkoShiba", 4.5m);
            Laptop shtaiga = new Laptop
                (
                "Lenovo Yoga 2 Pro", "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                8, "Intel HD Graphics 4400", "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",
                toshiba, 2259.00m
                );
            Laptop model = new Laptop("Ebanie", 200.00m);
            Laptop fourPar = new Laptop("4-ka pravec", "pravec procesor", "zdrav hard", 400.00m);
            Laptop sevenPar = new Laptop("7-ca pravec", "made in bulgaria", "pravec procesor", 4, "mnoo zdrav hard", "ekran ta drynka", 700.00m);


            Console.WriteLine("Shtaiga -> all");
            Console.WriteLine(shtaiga.ToString());
            Console.WriteLine("Ebanie -> Model & Price");
            Console.WriteLine(model.ToString());
            Console.WriteLine("4-ka pravec -> 4 par");
            Console.WriteLine(fourPar.ToString());
            Console.WriteLine("sedmak pravec -> 7 par");
            Console.WriteLine(sevenPar.ToString());
        }
    }
}
