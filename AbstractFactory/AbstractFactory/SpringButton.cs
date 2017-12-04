using System;

namespace AbstractFactory
{
    class SpringButton : Button 
    {
	    public void Display() 
        {
		    Console.WriteLine("显示浅绿色按钮。");
	    }
    }
}
