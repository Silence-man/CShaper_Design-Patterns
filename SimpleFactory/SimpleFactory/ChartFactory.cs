using System;

namespace SimpleFactory
{
    class ChartFactory
    {
        //静态工厂方法
        public static Chart GetChart(string type) 
        {
		    Chart chart = null;
		    if (type.Equals("histogram")) 
            {
			    chart = new HistogramChart();
			    Console.WriteLine("初始化设置柱状图！");
		    }
		    else if (type.Equals("pie")) 
            {
			    chart = new PieChart();
			    Console.WriteLine("初始化设置饼状图！");
		    }
		    else if (type.Equals("line")) 
            {
			    chart = new LineChart();
			    Console.WriteLine("初始化设置折线图！");			
		    }
		    return chart;
	    }
    }
}
