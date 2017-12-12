using System;

namespace StrategySample
{
    class ChildrenDiscount : Discount
    {
        private const double DISCOUNT = 10;
        public double Calculate(double price)
        {
            Console.WriteLine("儿童票：");
            return price - DISCOUNT;
        }
    }
}
