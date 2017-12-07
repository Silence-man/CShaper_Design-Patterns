using System;

namespace ProxySample
{
    class AccessValidator
    {
        //模拟实现登录验证
        public bool Validate(string userId) 
        {
		    Console.WriteLine("在数据库中验证用户'" + userId + "'是否是合法用户？");
		    if (userId.Equals("杨过")) {
			    Console.WriteLine("'{0}'登录成功！",userId);
			    return true;
		    }
		    else {
                Console.WriteLine("'{0}'登录失败！", userId);
			    return false;
		    }
	    }
    }
}
