using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAdaptee adaptee1 = new AdapterDouble.ConcreteAdaptee();
            ConcreteTarget target1 = new AdapterDouble.ConcreteTarget();

            Adapter adapter1 = new AdapterDouble.Adapter(adaptee1);
            adapter1.request();
            Adapter adapter2 = new AdapterDouble.Adapter(target1);
            adapter2.specificRequest();

            Console.ReadLine();
        }
    }
}
