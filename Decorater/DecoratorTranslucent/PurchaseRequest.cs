using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTranslucent
{
    class PurchaseRequest : Document
    {
        public override void Display()
        {
            Console.WriteLine("采购单显示");
        }
    }
}
