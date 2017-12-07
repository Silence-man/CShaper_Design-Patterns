using System;

namespace DecoratorSample
{
    class ListBox : VisualComponent
    {
        public override void Display()
        {
            Console.WriteLine("显示列表框！");
        }
    }
}
