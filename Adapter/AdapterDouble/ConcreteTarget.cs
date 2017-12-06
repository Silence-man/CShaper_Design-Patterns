using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDouble
{
    class ConcreteTarget : Target
    {
        public void request()
        {
            Console.Write("具体的原本目标");
        }
    }
}
