﻿namespace FactoryMethod
{
    class FileLoggerFactory : LoggerFactory 
    {
	    public Logger CreateLogger() 
        {
            //创建文件日志记录器对象
			Logger logger = new FileLogger(); 
			//创建文件，代码省略
			return logger;
	    }	
    }
}
