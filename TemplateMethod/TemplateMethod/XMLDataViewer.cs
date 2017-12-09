using System;

namespace TemplateMethod
{
    class XMLDataViewer : DataViewer
    {
        //实现父类方法：获取数据
        public override void GetData() 
        {
		    Console.WriteLine("从XML文件中获取数据。");
	    }

        //实现父类方法：显示数据
        public override void DisplayData() 
        {
            Console.WriteLine("以柱状图显示数据。");
	    }

        //覆盖父类的钩子方法
        public override bool IsNotXMLData()
        {
            return false;
        }
    }
}
