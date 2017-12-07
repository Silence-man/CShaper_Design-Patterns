using System;

namespace DecoratorSample
{
    class TextBox : VisualComponent
    {
        public override void Display()
        {
            Console.WriteLine("显示文本框！");
        }
    }
}
