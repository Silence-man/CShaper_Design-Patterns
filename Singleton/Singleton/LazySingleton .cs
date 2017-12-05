using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class LazySingleton
    {
        private static LazySingleton instance = null;
        //程序运行时创建一个静态只读的辅助对象
        private static readonly object syncObject = new object();
        private LazySingleton()
        { }
        public static LazySingleton getInstance()
        { 
            // 每个线程来之前先等待锁
            lock (syncObject)
            {
                if (instance == null)
                {
                    instance = new LazySingleton();
                }
            }
            return instance;
        }
    }

    class LazySingleton2
    {
        private static LazySingleton2 instance = null;
        //程序运行时创建一个静态只读的辅助对象
        private static readonly object syncRoot = new object();
        private LazySingleton2() { }
        public static LazySingleton2 GetInstance()
        {
            //第一重判断，先判断实例是否存在，不存在再加锁处理
            if (instance == null)
            {
                //加锁的程序在某一时刻只允许一个线程访问
                lock (syncRoot)
                {
                    //第二重判断
                    if (instance == null)
                    {
                        instance = new LazySingleton2();  //创建单例实例
                    }
                }
            }
            return instance;
        }
    }

}
