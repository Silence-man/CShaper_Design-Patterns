using System;

namespace FlyweightSample
{
    abstract class IgoChessman
    {
        public abstract string GetColor();

        public void Display() 
        {
		    Console.WriteLine("棋子颜色：" + this.GetColor());	
	    }

        public void Display(Coordinates coord)
        {
            Console.WriteLine("棋子颜色：{0}，棋子位置：{1}，{2}", this.GetColor(),coord.X,coord.Y);	
        }
    }
}
