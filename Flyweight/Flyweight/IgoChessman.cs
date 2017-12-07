using System;

namespace Flyweight
{
    abstract class IgoChessman
    {
        public abstract string GetColor();

        public void Display() 
        {
		    Console.WriteLine("棋子颜色：" + this.GetColor());	
	    }
    }
}
