using System;
using System.Collections.Generic;

namespace ObserverSample
{
    abstract class AllyControlCenter
    {
        protected string allyName; //战队名称
        protected List<IObserver> players = new List<IObserver>(); //定义一个集合用于存储战队成员

        public void SetAllyName(string allyName)
        {
            this.allyName = allyName;
        }

        public string GetAllyName()
        {
            return this.allyName;
        }

        //注册方法
        public void Join(IObserver obs) 
        {
            Console.WriteLine("{0}加入{1}战队！", obs.Name, this.allyName);
		    players.Add(obs);
	    }

        //注销方法
        public void Quit(IObserver obs) 
        {
            Console.WriteLine("{0}退出{1}战队！", obs.Name, this.allyName);
		    players.Remove(obs);
	    }

        //声明抽象通知方法
        public abstract void NotifyObserver(string name);
    }
}
