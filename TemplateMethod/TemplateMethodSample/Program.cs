using System;
using System.Configuration;
using System.Reflection;

namespace TemplateMethodSample
{
    class Program
    {
        static void Main(string[] args)
        {
     
            Account account;
            //读取配置文件
            string subClassStr = ConfigurationManager.AppSettings["subClass"];
            //反射生成对象
            account = (Account)Assembly.Load("TemplateMethodSample").CreateInstance(subClassStr);
            account.Handle("张无忌", "123456");
            /*
            Test t1;
            Test t2;
            t1 = new SubClassA();
            t2 = new SubClassB();
            t1.Prinf();
            t2.Prinf(); 
            */
            Console.Read();
        }
    }
}
