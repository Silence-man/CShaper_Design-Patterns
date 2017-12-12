namespace Memento
{
    public class Originator 
    {
        private string state;

        public Originator(string state)
        {
            this.state = state;
        }

　　    // 创建一个备忘录对象
        internal Memento CreateMemento() 
        {
　　　　    return new Memento(this);
        }

        // 根据备忘录对象恢复原发器状态
        internal void RestoreMemento(Memento m) 
        {
            state = m.GetState();
        }

        public void SetState(string state) 
        {
            this.state=state;
        }

        public string GetState() 
        {
            return this.state;
        }
    }

    //备忘录类，默认可见性，程序集内可见
    internal class Memento
    {
        private string state;

        internal Memento(Originator o)
        {
            state = o.GetState();
        }

        internal void SetState(string state)
        {
            this.state = state;
        }

        internal string GetState()
        {
            return this.state;
        }
    }

    public class Caretaker
    {
        private Memento memento;

        internal Memento GetMemento()
        {
            return memento;
        }

        internal void SetMemento(Memento memento)
        {
            this.memento = memento;
        }
    }
}
