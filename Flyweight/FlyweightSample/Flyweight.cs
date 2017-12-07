using System.Collections;

namespace FlyweightSample
{
    abstract class Flyweight
    {
        public abstract void Operation(string extrinsicState);
    }

    class ConcreteFlyweight : Flyweight
    {
        //内部状态intrinsicState作为成员变量，同一个享元对象其内部状态是一致的
	    private string intrinsicState;

        public ConcreteFlyweight(string intrinsicState) 
        {
		    this.intrinsicState = intrinsicState;
	    }
	
        //外部状态extrinsicState在使用时由外部设置，不保存在享元对象中，即使是同一个对象，在每一次调用时可以传入不同的外部状态
	    public override void Operation(string extrinsicState) 
        {
		    //实现业务方法
	    }	
    }

    class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(string extrinsicState)
        {
            //实现业务方法
        }
    }

    class FlyweightFactory
    {
        //定义一个Hashtable用于存储享元对象，实现享元池
        private Hashtable flyweights = new Hashtable();

        public Flyweight GetFlyweight(string key)
        {
            //如果对象存在，则直接从享元池获取
            if (flyweights.ContainsKey(key))
            {
                return (Flyweight)flyweights[key];
            }
            //如果对象不存在，先创建一个新的对象添加到享元池中，然后返回
            else
            {
                Flyweight fw = new ConcreteFlyweight("state");
                flyweights.Add(key,fw);
                return fw;
            }
        }
    }
}
