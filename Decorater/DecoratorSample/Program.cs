using System;

namespace DecoratorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            VisualComponent component, componentSB, componentBB; //使用抽象构件定义
            component = new Window(); //定义具体构件
            componentSB = new ScrollBarDecorator(component); //定义装饰后的构件
            componentBB = new BlackBorderDecorator(componentSB);//将装饰了一次之后的对象继续注入到另一个装饰类中，进行第二次装饰
            componentBB.Display();
            Console.Read();
        }
    }
}
