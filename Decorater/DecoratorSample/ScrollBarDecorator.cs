using System;

namespace DecoratorSample
{
    class ScrollBarDecorator : ComponentDecorator
    {
        public ScrollBarDecorator(VisualComponent component)
            : base(component)
        {
        }

        public override void Display()
        {
            this.SetScrollBar();
            base.Display();
        }

        public void SetScrollBar() 
        {
		    Console.WriteLine("为构件增加滚动条！");
	    }
    }
}
