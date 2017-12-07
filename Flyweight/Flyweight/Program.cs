using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            IgoChessman black1, black2, black3, white1, white2;
            IgoChessmanFactory factory;

            //获取享元工厂对象
            factory = IgoChessmanFactory.GetInstance();

            //通过享元工厂获取三颗黑子
            black1 = factory.GetIgoChessman("b");
            black2 = factory.GetIgoChessman("b");
            black3 = factory.GetIgoChessman("b");
            Console.WriteLine("判断两颗黑子是否相同：" + (black1 == black2));

            //通过享元工厂获取两颗白子
            white1 = factory.GetIgoChessman("w");
            white2 = factory.GetIgoChessman("w");
            Console.WriteLine("判断两颗白子是否相同：" + (white1 == white2));

            //显示棋子
		    black1.Display();
		    black2.Display();
		    black3.Display();
		    white1.Display();
		    white2.Display();

            Console.ReadLine();
        }
    }
}
