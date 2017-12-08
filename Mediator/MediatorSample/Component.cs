namespace MediatorSample
{
    abstract class Component
    {
        protected Mediator mediator;

        public void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }

        //转发调用
        public void Changed()
        {
            mediator.ComponentChanged(this);
        }

        public abstract void Update();
    }
}
