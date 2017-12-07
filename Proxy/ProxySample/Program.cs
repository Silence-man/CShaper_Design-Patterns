using System;
using System.Configuration;
using System.Reflection;

namespace ProxySample
{
    class Program
    {
        static void Main(string[] args)
        {
            //读取配置文件
            string proxy = ConfigurationManager.AppSettings["proxy"];

            //反射生成对象，针对抽象编程，客户端无须分辨真实主题类和代理类
            Searcher searcher;
            searcher = (Searcher)Assembly.Load("ProxySample").CreateInstance(proxy);

            String result = searcher.DoSearch("杨过", "玉女心经");
            Console.Read();
        }
    }
}
