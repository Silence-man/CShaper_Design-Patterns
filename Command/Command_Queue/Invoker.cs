using System;

namespace Command_Queue
{
    class Invoker
    {
        private CommandQueue commandQueue; //维持一个CommandQueue对象的引用

        //构造注入
        public Invoker(CommandQueue commandQueue)
        {
            this.commandQueue = commandQueue;
        }

        //设值注入
        public void SetCommandQueue(CommandQueue commandQueue)
        {
            this.commandQueue = commandQueue;
        }

        //调用CommandQueue类的Execute()方法
        public void Call()
        {
            Console.WriteLine("开始执行命令");
            commandQueue.Execute();
        }
    }
}
