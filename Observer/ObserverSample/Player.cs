using System;

namespace ObserverSample
{
    class Player : IObserver
    {
        private string name;

        public Player(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //支援盟友方法的实现
        public void Help()
        {
            Console.WriteLine("坚持住，{0}来救你！", this.name);
	    }

        //遭受攻击方法的实现，当遭受攻击时将调用战队控制中心类的通知方法NotifyObserver()来通知盟友
        public void BeAttacked(AllyControlCenter acc) 
        {
            Console.WriteLine("{0}被攻击！", this.name);
            acc.NotifyObserver(name);		
	    }
    }
}
