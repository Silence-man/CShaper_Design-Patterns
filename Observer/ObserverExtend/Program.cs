using System;

namespace ObserverExtend
{
    class Program
    {
        public Program(EventTest test)
        {
            //注册事件或订阅事件
            test.OnUserInput += new EventTest.UserInput(Handler);
            test.OnUserInput += new EventTest.UserInput(HandlerMore);
            //注销事件或取消订阅
            //test.OnUserInput -= new EventTest.UserInput(Handler);
        }

        public void Handler(object sender, EventArgs e)
        {
            Console.WriteLine("数据输入结束！");
        }

        public void HandlerMore(object sender, EventArgs e)
        {
            Console.WriteLine("真的结束了！");
        }

        static void Main(string[] args)
        {
            EventTest test = new EventTest();
            Program program = new Program(test);
            test.Method();
        }
    }
}
