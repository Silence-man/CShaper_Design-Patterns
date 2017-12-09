using System;

namespace ObserverExtend
{
    class EventTest
    {
        //定义一个委托
        public delegate void UserInput(object sender, EventArgs e);

        //定义一个此委托类型的事件
        public event UserInput OnUserInput;

        //模拟事件触发，当输入“0”时引发事件
        public void Method()
        {
            bool flag = false;
            Console.WriteLine("请输入数字：");
            while (!flag)
            {
                if (Console.ReadLine() == "0")
                {
                    OnUserInput(this, new EventArgs());
                }
            }
        }
    }
}
