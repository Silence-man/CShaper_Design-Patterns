using System;

namespace ProxySample
{
    class Logger
    {
        //模拟实现日志记录
        public void Log(string userId) {
            Console.WriteLine("更新数据库，用户'{0}'查询次数加1！",userId);
	    }
    }
}
