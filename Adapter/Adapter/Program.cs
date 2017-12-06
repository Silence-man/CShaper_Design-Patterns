using System;
using System.Configuration;
using System.Reflection;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ScoreOperation operation;  //针对抽象目标接口编程
		    
            //读取配置文件
            string adapterType = ConfigurationManager.AppSettings["adapter"];
            //反射生成对象
            operation = (ScoreOperation)Assembly.Load("Adapter").CreateInstance(adapterType);

		    int[] scores = {84,76,50,69,90,91,88,96}; //定义成绩数组
		    int[] result;
		    int score;
		
		    Console.WriteLine("成绩排序结果：");
		    result = operation.Sort(scores);

            //遍历输出成绩
		    foreach (int i in result) 
            {
			    Console.Write(i + ",");
		    }
		    Console.WriteLine();
		
		    Console.WriteLine("查找成绩90：");
		    score = operation.Search(result,90);
		    if (score != -1) 
            {
			     Console.WriteLine("找到成绩90。");
		    }
		    else 
            {
			    Console.WriteLine("没有找到成绩90。");
		    }
		
		    Console.WriteLine("查找成绩92：");
		    score = operation.Search(result,92);
		    if (score != -1) 
            {
			     Console.WriteLine("找到成绩92。");
		    }
		    else 
            {
                Console.WriteLine("没有找到成绩92。");
		    }

            Console.Read();
        }
    }
}
