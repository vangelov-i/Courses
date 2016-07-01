namespace BunnyWars.Core
{
    using System.Collections.Generic;

    class BunnyWarsTestingGround
    {
        static void Main(string[] args)
        {
            var asd = new HashSet<Bunny>();
            var bunny = new Bunny("zaio", 1, 0);
            asd.Add(bunny);
            foreach (var bunny1 in asd)
            {
                bunny1.Health = 1;
            }
        }
    }
}
