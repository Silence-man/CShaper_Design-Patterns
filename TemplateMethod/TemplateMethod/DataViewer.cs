using System;

namespace TemplateMethod
{
    abstract class DataViewer
    {
        //抽象方法：获取数据
        public abstract void GetData();

        //具体方法：转换数据
        public void ConvertData() 
        {
		    Console.WriteLine("将数据转换为XML格式。");
	    }

        //抽象方法：显示数据
        public abstract void DisplayData();

        //钩子方法：判断是否为XML格式的数据
        public virtual bool IsNotXMLData()
        {
            return true;
        }

        //模板方法
        public void Process()
        {
            GetData();
            //如果不是XML格式的数据则进行数据转换
            if (IsNotXMLData())
            {
                ConvertData();
            }
            DisplayData();
        }
    }
}
