using System;

namespace StateSample
{
    class OverdraftState : AccountState
    {
        public OverdraftState(AccountState state)
        {
            this.Acc = state.Acc;
        }

        public override void Deposit(double amount)
        {
            Acc.Balance = Acc.Balance + amount;
            StateCheck();
        }

        public override void Withdraw(double amount)
        {
            Acc.Balance = Acc.Balance - amount;
            StateCheck();
        }

        public override void ComputeInterest() 
        {
		    Console.WriteLine("计算利息！");
	    }

        //状态转换
        public override void StateCheck() 
        {
		    if (Acc.Balance > 0) 
            {
			    Acc.SetState(new NormalState(this));
		    }
		    else if (Acc.Balance == -2000) 
            {
			    Acc.SetState(new RestrictedState(this));
		    }
		    else if (Acc.Balance < -2000) 
            {
			    Console.WriteLine("操作受限！");
		    }
	    }
    }
}
