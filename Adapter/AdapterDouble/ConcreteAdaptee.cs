using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDouble
{
    class ConcreteAdaptee : Adaptee
    {
        public void specificRequest()
        {
            Console.WriteLine("具体的新的适配者目标");
        }
    }
}
