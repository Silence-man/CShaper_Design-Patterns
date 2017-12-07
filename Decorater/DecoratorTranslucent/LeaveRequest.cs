using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTranslucent
{
    class LeaveRequest : Document
    {
        public override void Display()
        {
            Console.WriteLine("请假单显示"); 
        }
    }
}
