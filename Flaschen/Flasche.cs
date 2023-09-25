using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flaschen
{
    internal class Bottle<T> where T : class
    {
        T content;
        public bool IsEmpty()
        {
            return content == null;
        }
        public void FillBottle(T content)
        {
            this.content = content;
        }
        public T Empty()
        {
            T returnen = content;           
            content = null;
            return returnen;
        }
    }
}
