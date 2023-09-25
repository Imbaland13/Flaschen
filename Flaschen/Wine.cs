using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flaschen
{
    internal class Wine
    {
        string name;
        string origin;
        public Wine(string name, string origin) 
        {
            this.name = name;
            this.origin = origin;
        }
        public string Origin()
        {
            return origin;
        }
        public void PrintOrigin()
        {
            Console.WriteLine(name + " kommt aus: " + origin);
        }
    }
}
