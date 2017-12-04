using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用抽象层定义
            SkinFactory factory;
            Button bt;
            TextField tf;
            ComboBox cb;

            //读取配置文件
            string factoryType = ConfigurationManager.AppSettings["factory"];

            //反射生成对象
            factory = (SkinFactory)Assembly.Load("AbstractFactory").CreateInstance(factoryType);

            bt = factory.CreateButton();
            tf = factory.CreateTextField();
            cb = factory.CreateComboBox();
            bt.Display();
            tf.Display();
            cb.Display();

            Console.Read();
        }
    }
}
