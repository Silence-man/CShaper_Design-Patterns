using System;

namespace ProxySample
{
    class RealSearcher : Searcher
    {
        //模拟查询商务信息
        public string DoSearch(string userId, string keyword) {
            Console.WriteLine("用户'{0}'使用关键词'{1}'查询商务信息！",userId,keyword);
		    return "返回具体内容";
	    }
    }
}
