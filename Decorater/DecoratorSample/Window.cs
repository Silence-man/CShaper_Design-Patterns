using System;

namespace DecoratorSample
{
    class Window : VisualComponent
    {
        public override void Display()
        {
            Console.WriteLine("显示窗体！");
        }
    }
}
