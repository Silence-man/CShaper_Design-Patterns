using System;

namespace DecoratorTranslucent
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc; //使用抽象构件类型定义
            doc = new PurchaseRequest();
            Approver newDoc; //使用具体装饰类型定义
            newDoc = new Approver(doc);
            newDoc.Display();//调用原有业务方法
            newDoc.Approve();//调用新增业务方法
            Console.Read();
        }
    }
}
