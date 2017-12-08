using System;

namespace CoRSample
{
    class Congress : Approver
    {
        public Congress(string name) : base(name)
        {
        }

        //具体请求处理方法
        public override void ProcessRequest(PurchaseRequest request) 
        {
 		    Console.WriteLine("召开董事会审批采购单：{0}，金额：{1}元，采购目的：{2}。",request.Number, request.Amount, request.Purpose);	    //处理请求
 	    }  
    }
}
