using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            WeeklyLog log_previous = new WeeklyLog();  //创建原型对象
            log_previous.setName("张无忌");
            log_previous.setDate("第12周");
            log_previous.setContent("这周工作很忙，每天加班！");

            Console.WriteLine("****周报****");
            Console.WriteLine("周次：" + log_previous.getDate());
            Console.WriteLine("姓名：" + log_previous.getName());
            Console.WriteLine("内容：" + log_previous.getContent());
            Console.WriteLine("--------------------------------");

            WeeklyLog log_new;
            log_new = (WeeklyLog)log_previous.Clone(); //调用克隆方法创建克隆对象
            log_new.setDate("第13周");
            Console.WriteLine("****周报****");
            Console.WriteLine("周次：" + log_new.getDate());
            Console.WriteLine("姓名：" + log_new.getName());
            Console.WriteLine("内容：" + log_new.getContent());
        }
    }
}
