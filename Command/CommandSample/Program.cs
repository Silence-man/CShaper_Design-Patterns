using System;
using System.Configuration;
using System.Reflection;

namespace CommandSample
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionButton fb = new FunctionButton();
            
            Command command;
            //读取配置文件
            string commandStr = ConfigurationManager.AppSettings["command"];
            //反射生成对象
            command = (Command)Assembly.Load("CommandSample").CreateInstance(commandStr);

            //设置命令对象
            fb.Command = command;
            fb.Click();

            Console.Read();
        }
    }
}
