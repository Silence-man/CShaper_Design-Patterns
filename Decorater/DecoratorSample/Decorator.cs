namespace DecoratorSample
{
    abstract class Component
    {
        public abstract void Operation();
    }

    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            //基本功能实现
        }
    }

    class Decorator : Component
    {
        private Component component;  //维持一个对抽象构件对象的引用

        //注入一个抽象构件类型的对象
        public Decorator(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            component.Operation();  //调用原有业务方法
        }
    }

    class ConcreteDecorator : Decorator 
    {
        public ConcreteDecorator(Component component) : base(component)
        {
	    }

	    public override void Operation() 
        {
		    base.Operation();  //调用原有业务方法
		    AddedBehavior();  //调用新增业务方法
	    }

        //新增业务方法
	    public void AddedBehavior() 
        {	
            //功能扩展
        }
    }
}
