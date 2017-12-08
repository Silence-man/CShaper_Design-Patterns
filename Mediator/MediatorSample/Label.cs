using System;

namespace MediatorSample
{
    class Label : Component
    {
        public override void Update() 
        {
		    Console.WriteLine("文本标签内容改变，客户信息总数加1。");
	    }
    }
}
