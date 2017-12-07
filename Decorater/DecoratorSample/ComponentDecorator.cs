namespace DecoratorSample
{
    class ComponentDecorator : VisualComponent
    {
        private VisualComponent component;  //维持对抽象构件类型对象的引用

        //注入抽象构件类型的对象
        public ComponentDecorator(VisualComponent component)
        {
            this.component = component;
        }

        public override void Display()
        {
            component.Display();
        }
    }
}
