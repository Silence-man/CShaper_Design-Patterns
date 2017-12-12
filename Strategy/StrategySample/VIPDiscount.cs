using System;

namespace StrategySample
{
    class VIPDiscount : Discount
    {
        private const double DISCOUNT = 0.5;
        public double Calculate(double price)
        {
            Console.WriteLine("VIP票：");
            Console.WriteLine("增加积分！");
            return price * DISCOUNT;
        }
    }
}
