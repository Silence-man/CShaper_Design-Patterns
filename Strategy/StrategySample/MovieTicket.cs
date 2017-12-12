namespace StrategySample
{
    class MovieTicket
    {
        private double price;
        private Discount discount; //维持一个对抽象折扣类的引用

        //注入一个折扣类对象
        public void SetDiscount(Discount discount)
        {
            this.discount = discount;
        }

        public double Price
        {
            get {
                //调用折扣类的折扣价计算方法
                return discount.Calculate(this.price); 
            }
            set { price = value; }
        }
    }
}
