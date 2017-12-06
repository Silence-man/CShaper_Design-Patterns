using System;
using System.Configuration;
using System.Reflection;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Image image;//图片格式
            ImageImp imp;//系统平台

            //读取配置文件
            string imageType = ConfigurationManager.AppSettings["image"];
            string osType = ConfigurationManager.AppSettings["os"];
            
            //反射生成对象
            image = (Image)Assembly.Load("Bridge").CreateInstance(imageType);
            imp = (ImageImp)Assembly.Load("Bridge").CreateInstance(osType);
            
            image.SetImageImp(imp);
            image.ParseFile("中国地图");
            Console.Read();
        }
    }
}
