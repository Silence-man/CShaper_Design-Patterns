using System;

namespace TemplateMethodSample
{
    abstract class Test
    {
        public virtual void Prinf()
        {
            Console.WriteLine("这是虚方法");
        } 
    }

    class SubClassA : Test
    {
        public override void Prinf()
        {
            Console.WriteLine("这是override的新方法");
        } 
    }

    class SubClassB : Test
    {
        public new void Prinf()
        {
            Console.WriteLine("这是new的新方法");
        }
    }
}
