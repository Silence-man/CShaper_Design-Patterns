using System;

namespace FactoryMethod
{
    class DatabaseLogger : Logger 
    {
	    public void WriteLog() 
        {
		    Console.WriteLine("数据库日志记录。");
	    }
    }
}
