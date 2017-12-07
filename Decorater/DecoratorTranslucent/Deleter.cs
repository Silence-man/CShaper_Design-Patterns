using System;

namespace DecoratorTranslucent
{
    class Deleter : Decorator
    {
        public Deleter(Document document):base(document)
        {
            Console.WriteLine("增加审批功能！");
        }
        public void Delete()
        {
            Console.WriteLine("审批文件！");
        }

    }
}
