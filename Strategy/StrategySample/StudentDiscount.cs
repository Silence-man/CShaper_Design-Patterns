using System;

namespace StrategySample
{
    class StudentDiscount : Discount
    {
        private const double DISCOUNT = 0.8; 
        public double Calculate(double price) 
        {
		    Console.WriteLine("学生票：");
            return price * DISCOUNT;
	    }
    }
}
