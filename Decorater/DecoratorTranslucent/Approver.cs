using System;

namespace DecoratorTranslucent
{
    class Approver : Decorator
    {
        public Approver(Document document):base(document)
        {
            Console.WriteLine("增加审批功能！");
        }
        public void Approve()
        {
            Console.WriteLine("审批文件！");
        }
    }
}
