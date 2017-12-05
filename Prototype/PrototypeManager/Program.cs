using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeManagerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            PrototypeManager pm = new PrototypeManager();

            Console.WriteLine("是否相同？{0}", (pm.Get("A") == pm.Get("A")) ? "是" : "否");
            Console.Read();
        }
    }
}
