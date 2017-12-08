using System;

namespace CoRSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Approver wjzhang, gyang, jguo, meeting;
            //Approver rhuang;
            //rhuang = new Manager("黄蓉");

            wjzhang = new Director("张无忌");
            gyang = new VicePresident("杨过");
            jguo = new President("郭靖");
            meeting = new Congress("董事会");

            //创建职责链
            wjzhang.SetSuccessor(gyang);
            gyang.SetSuccessor(jguo);
            jguo.SetSuccessor(meeting);

            //wjzhang.SetSuccessor(rhuang); //将“黄蓉”作为“张无忌”的下家
            //rhuang.SetSuccessor(gyang); //将“杨过”作为“黄蓉”的下家
            //gyang.SetSuccessor(jguo);
            //jguo.SetSuccessor(meeting);


            //创建采购单
            PurchaseRequest pr1 = new PurchaseRequest(45000, 10001, "购买倚天剑");
            wjzhang.ProcessRequest(pr1);

            PurchaseRequest pr2 = new PurchaseRequest(60000, 10002, "购买《葵花宝典》");
            wjzhang.ProcessRequest(pr2);

            PurchaseRequest pr3 = new PurchaseRequest(160000, 10003, "购买《金刚经》");
            wjzhang.ProcessRequest(pr3);

            PurchaseRequest pr4 = new PurchaseRequest(800000, 10004, "购买桃花岛");
            wjzhang.ProcessRequest(pr4);

            Console.Read();
        }
    }
}
