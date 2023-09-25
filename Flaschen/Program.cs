using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flaschen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wine wine = new Wine("Weißwein", "Frankreich");
            Beer beer = new Beer("Weizen", "Paulaner");
            Bottle<Wine> bottle = new Bottle<Wine>();
            Bottle<Beer> bottle1 = new Bottle<Beer>();
            bottle.FillBottle(wine);
            bottle.IsEmpty();
            var content = bottle.Empty();
            Console.WriteLine(content.Origin());
        }
    }
}
