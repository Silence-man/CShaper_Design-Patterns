using System;
using System.Configuration;
using System.Reflection;

namespace AbstractFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            //EncryptFacade ef = new EncryptFacade();
            //ef.FileEncrypt("src.txt", "des.txt");
            AbstractEncryptFacade ef; //针对抽象建造者编程
            //读取配置文件
            string facadeString = ConfigurationManager.AppSettings["facade"];
            //反射生成对象
            ef = (AbstractEncryptFacade)Assembly.Load("AbstractFacade").CreateInstance(facadeString);
            ef.FileEncrypt("src.txt", "des.txt");
            Console.Read();
        }
    }
}
