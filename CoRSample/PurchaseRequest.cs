namespace CoRSample
{
    class PurchaseRequest
    {
        private double amount;  //采购金额
        private int number;  //采购单编号
        private string purpose;  //采购目的

        public PurchaseRequest(double amount, int number, string purpose)
        {
            this.amount = amount;
            this.number = number;
            this.purpose = purpose;
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Purpose
        {
            get { return purpose; }
            set { purpose = value; }
        }
    }
}
