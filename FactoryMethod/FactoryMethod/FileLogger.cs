using System;

namespace FactoryMethod
{
    class FileLogger : Logger 
    {
        public void WriteLog()
        {
		    Console.WriteLine("文件日志记录。");
	    }
    }
}
