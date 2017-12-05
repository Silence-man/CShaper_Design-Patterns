using System;
using System.Collections;

namespace Singleton
{
    class LoadBalancer
    {
        //私有静态成员变量，存储唯一实例
        private static LoadBalancer instance = null;
        //服务器集合
        private ArrayList serverList = null;

        //私有构造函数
        private LoadBalancer()
        {
            serverList = new ArrayList();
        }

        //公有静态成员方法，返回唯一实例
        public static LoadBalancer GetLoadBalancer()
        {
            if (instance == null)
            {
                instance = new LoadBalancer();
            }
            return instance;
        }

        //增加服务器
        public void AddServer(string server)
        {
            serverList.Add(server);
        }

        //删除服务器
        public void RemoveServer(string server)
        {
            serverList.Remove(server);
        }

        //使用Random类随机获取服务器
        public string GetServer()
        {
            Random random = new Random();
            int i = random.Next(serverList.Count);
            return serverList[i].ToString();
        }
    }
}
