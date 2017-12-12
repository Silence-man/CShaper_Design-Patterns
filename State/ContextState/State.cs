using System;

namespace ContextState
{
    //抽象状态类  
    abstract class State
    {
        public abstract void display();
    }

    //正常状态类  
    class NormalState : State
    {
        public override void display()
        {
            Console.WriteLine("正常大小！");
        }
    }

    //二倍状态类  
    class LargerState : State
    {
        public override void display()
        {
            Console.WriteLine("二倍大小！");
        }
    }

    //四倍状态类  
    class LargestState : State
    {
        public override void display()
        {
            Console.WriteLine("四倍大小！");
        }
    }
}
