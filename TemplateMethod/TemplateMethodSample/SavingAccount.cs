using System;

namespace TemplateMethodSample
{
    class SavingAccount : Account
    {
        //覆盖父类的抽象基本方法
        public override void CalculateInterest() 
        {
		    Console.WriteLine("按定期利率计算利息！");
	    }
    }
}
