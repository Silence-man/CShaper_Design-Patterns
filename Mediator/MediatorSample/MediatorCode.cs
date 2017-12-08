using System.Collections.Generic;

namespace MediatorSample
{
    /*
    abstract class Mediator
    {
        protected List<Colleague> colleagues = new List<Colleague>(); //用于存储同事对象

        //注册方法，用于增加同事对象
        public void Register(Colleague colleague)
        {
            colleagues.Add(colleague);
        }

        //声明抽象的业务方法
        public abstract void Operation();
    }

    class ConcreteMediator : Mediator
    {
        //实现业务方法，封装同事之间的调用
        public override void Operation() 
        {
		    //......
		    ((Colleague)(colleagues[0])).Method1(); //通过中介者调用同事类的方法
		    //......
	    }
    }

    abstract class Colleague
    {
        protected Mediator mediator; //维持一个抽象中介者的引用

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public abstract void Method1(); //声明自身方法，处理自己的行为

        //定义依赖方法，与中介者进行通信
        public void Method2()
        {
            mediator.Operation();
        }
    }

    class ConcreteColleague : Colleague
    {
        public ConcreteColleague(Mediator mediator)
            : base(mediator)
        {
        }

        //实现自身方法
        public override void Method1() 
        {
		    //......
	    }
    }
    */
}
