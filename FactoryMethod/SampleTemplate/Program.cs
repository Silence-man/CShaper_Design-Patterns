using System;
using System.Configuration;

namespace SampleTemplateShow
{
    class Program
    {
        static void Main(string[] args)
        {


            LoggerFactory factory;
            Logger logger;
            factory = new FileLoggerFactory(); //可引入配置文件实现
            logger = factory.CreateLogger();
            logger.WriteLog();

            Console.Read();
        }
    }
}
