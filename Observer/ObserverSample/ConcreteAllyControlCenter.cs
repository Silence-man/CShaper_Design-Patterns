using System;

namespace ObserverSample
{
    class ConcreteAllyControlCenter : AllyControlCenter
    {
        public ConcreteAllyControlCenter(string allyName) 
        {
            Console.WriteLine("{0}战队组建成功！", allyName);
            Console.WriteLine("----------------------------");
		    this.allyName = allyName;
	    }

        //实现通知方法
        public override void NotifyObserver(string name) 
        {
            Console.WriteLine("{0}战队紧急通知，盟友{1}遭受敌人攻击！", this.allyName, name);
            //遍历观察者集合，调用每一个盟友（自己除外）的支援方法
            foreach(object obs in players) 
            {
                if (!((IObserver)obs).Name.Equals(name)) 
                {
                    ((IObserver)obs).Help();
                }
            }		
	    }
    }
}
