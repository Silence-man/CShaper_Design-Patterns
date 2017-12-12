using System;
using System.Configuration;
using System.Reflection;

namespace StrategySample
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieTicket mt = new MovieTicket();
		    double originalPrice = 60.0;
		    double currentPrice;
		
		    mt.Price = originalPrice;
		    Console.WriteLine("原始价为：{0}",originalPrice);
		    Console.WriteLine("---------------------------------");
			
		    Discount discount;
            //读取配置文件
            string discountType = ConfigurationManager.AppSettings["discountType"];
            //反射生成具体折扣对象
		    discount = (Discount)Assembly.Load("StrategySample").CreateInstance(discountType);
		    //注入折扣对象
            mt.SetDiscount(discount); 
		   
		    currentPrice = mt.Price;
            Console.WriteLine("折后价为：{0}",currentPrice);
            Console.Read();
        }
    }
}
