using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerFactory factory;
            Logger logger;
            //读取配置文件
            string factoryString = ConfigurationManager.AppSettings["factory"];
            //反射生成对象
            factory = (LoggerFactory)Assembly.Load("FactoryMethod").CreateInstance(factoryString);
            logger = factory.CreateLogger();
            logger.WriteLog();

            Console.ReadLine();
        }
    }
}
