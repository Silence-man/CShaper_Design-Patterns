using System;

namespace MediatorSample
{
    class TextBox : Component 
    {
	    public override void Update() 
        {
		    Console.WriteLine("客户信息增加成功后文本框清空。");
	    }
	
	    public void SetText() 
        {
		    Console.WriteLine("文本框显示：小龙女。");
	    }
    }
}
