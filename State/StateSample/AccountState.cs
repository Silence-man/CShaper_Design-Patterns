namespace StateSample
{
    abstract class AccountState
    {
        private Account acc;

        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }
        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void ComputeInterest();
        public abstract void StateCheck();
    }
}
