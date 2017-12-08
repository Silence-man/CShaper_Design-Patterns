using System;

namespace CoRSample
{
    class Manager : Approver
    {
        public Manager(string name) : base(name)
        {
        }

        //具体请求处理方法
        public override void ProcessRequest(PurchaseRequest request) 
        {
 		    if (request.Amount < 80000) 
            {
 			    Console.WriteLine("经理{0}审批采购单：{1}，金额：{2}元，采购目的：{3}。", this.name, request.Number, request.Amount, request.Purpose);  //处理请求
 		    }
 		    else 
            {
 			    this.successor.ProcessRequest(request);  //转发请求
 		    }
 	    }
    }
}
