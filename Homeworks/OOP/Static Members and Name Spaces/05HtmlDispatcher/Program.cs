using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// nqma mnogo smisyl da q proverqvash, samo sym q zapochnal i taka i ne se vyrnah da q dovyrsha

namespace _05HtmlDispatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAttributes("id", "page");
            div.AddAttributes("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div*2);
        }
    }
}
