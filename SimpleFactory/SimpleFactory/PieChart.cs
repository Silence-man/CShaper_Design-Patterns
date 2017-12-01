using System;

namespace SimpleFactory
{
    class PieChart : Chart 
    {
	    public PieChart() 
        {
		    Console.WriteLine("创建饼状图！");
	    }
	
	    public void Display() 
        {
		    Console.WriteLine("显示饼状图！");
	    }
    }
}
