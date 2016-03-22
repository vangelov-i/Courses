using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        
        Component processor = new Component("processor", "stavasht", 100.55m);
        Component graphics = new Component("graphics", 50.5m);
        Component card = new Component("card", "mnoo zdrava karta", 77.7m);
        Component motherboard = new Component("maika dyska", 100);

        Computer all = new Computer("Pravec all", processor, graphics, card, motherboard);
        Computer procMotherPrice = new Computer("djigi", processor, motherboard);

        Component intelche = new Component("intel", 237.7m);
        Component maikaPravec = new Component("dyno", 158.7m);

        Computer third = new Computer("Pentium", intelche, maikaPravec);


        Computer[] vsichki = {all,procMotherPrice, third};
        List<Computer> PcList = vsichki.OrderBy(si => si.TotalPrice).ToList();

        foreach (Computer pc in PcList)
        {
            Console.WriteLine(pc.ToString());
            Console.WriteLine("-------------");
        }

    }
}