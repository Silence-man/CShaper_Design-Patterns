using System;

namespace StateSample
{
    class NormalState : AccountState
    {
        public NormalState(Account acc)
        {
            this.Acc = acc;
        }

        public NormalState(AccountState state)
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
		    Console.WriteLine("正常状态，无须支付利息！");
	    }

        //状态转换
        public override void StateCheck() 
        {
		    if (Acc.Balance > -2000 && Acc.Balance <= 0) 
            {
			    Acc.SetState(new OverdraftState(this));
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