using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            
          Builder builder = new ConcreteBuilder1(); //可通过配置文件实现
          Director director = new Director(builder);
          Product product = director.Construct();
          Console.WriteLine(product.PartA);
          Console.WriteLine(product.PartB);
          Console.WriteLine(product.PartC);
          Console.Read();
          
        }
    }
}
