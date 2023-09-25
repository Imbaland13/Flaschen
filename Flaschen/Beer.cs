using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Flaschen
{
    internal class Beer
    {
        private string beer;
        private string brewery;
        public Beer(string beer, string brewery) 
        {
            this.beer = beer;
            this.brewery = brewery;
        }
        public void PrintOrigin()
        {
            Console.WriteLine(beer + " kommt aus: " + brewery);
        }
    }
}
