namespace TemplateMethodSample
{
    abstract class AbstractClass
    {
        //模板方法
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            PrimitiveOperation3();
        }

        //基本方法—具体方法
        public void PrimitiveOperation1()
        {
            //实现代码
        }

        //基本方法—抽象方法
        public abstract void PrimitiveOperation2();

        //基本方法—钩子方法
        public virtual void PrimitiveOperation3()
        { }
    }

    class ConcreteClass : AbstractClass
    {
        public override void PrimitiveOperation2()
        {
            //实现代码
        }

        public override void PrimitiveOperation3()
        {
            //实现代码
        }
    }
}
