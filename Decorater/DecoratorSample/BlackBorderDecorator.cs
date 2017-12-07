using System;

namespace DecoratorSample
{
    class BlackBorderDecorator : ComponentDecorator
    {
        public BlackBorderDecorator(VisualComponent component)
            : base(component)
        {
        }

        public override void Display()
        {
            this.SetBlackBorder();
            base.Display();
        }

        public void SetBlackBorder() 
        {
		    Console.WriteLine("为构件增加黑色边框！");
	    }
    }
}
