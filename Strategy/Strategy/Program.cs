using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieTicket mt = new MovieTicket();
            double originalPrice = 60.0; //原始票价  
            double currentPrice; //折后价  

            mt.setPrice(originalPrice);
            Console.WriteLine("原始价为：" + originalPrice);
            Console.WriteLine("---------------------------------");

            mt.setType("student"); //学生票  
            currentPrice = mt.getPrice();
            Console.WriteLine("折后价为：" + currentPrice);
            Console.WriteLine("---------------------------------");

            mt.setType("children"); //儿童票  
            currentPrice = mt.getPrice();
            Console.WriteLine("折后价为：" + currentPrice);
            Console.ReadLine();
        }
    }
   
}
