using System;

namespace StateSample
{
    class Account
    {
        private AccountState state; //维持一个对抽象状态对象的引用
        private string owner; //开户名
        private double balance = 0; //账户余额

        public Account(string owner, double init) 
        {
		    this.owner = owner;
		    this.balance = init;
		    this.state = new NormalState(this); //设置初始状态
            Console.WriteLine("{0}开户，初始金额为{1}", this.owner ,init);
            Console.WriteLine("---------------------------------------------");	
	    }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void SetState(AccountState state)
        {
            this.state = state;
        }

        public void Deposit(double amount) 
        {
            Console.WriteLine("{0}存款{1}", this.owner,amount);
		    state.Deposit(amount); //调用状态对象的Deposit()方法
		    Console.WriteLine("现在余额为{0}", this.Balance);
		    Console.WriteLine("现在帐户状态为{0}",this.state.GetType().ToString());
            Console.WriteLine("---------------------------------------------");			
	    }

        public void Withdraw(double amount) 
        {
		    Console.WriteLine("{0}取款{1}",this.owner, amount);
            state.Withdraw(amount); //调用状态对象的Withdraw()方法
		    Console.WriteLine("现在余额为{0}", this.Balance);
            Console.WriteLine("现在帐户状态为{0}", this.state.GetType().ToString());
            Console.WriteLine("---------------------------------------------");
	}

        public void ComputeInterest()
        {
            state.ComputeInterest(); //调用状态对象的ComputeInterest()方法
        }
    }
}
