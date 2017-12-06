using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    //演示 没有实际作用
    interface Implementor 
    {
        void OperationImpl();
    }

    class ConcreteImplementor : Implementor
    {
        public void OperationImpl()
        {
            //具体业务方法实现
        }
    }

    abstract class Abstraction
    {
        protected Implementor impl; //定义实现类接口对象

        public void SetImpl(Implementor impl)
        {
            this.impl = impl;
        }

        public abstract void Operation();  //声明抽象业务方法
    }

    class RefinedAbstraction : Abstraction 
    {
	    public override void Operation() {
		    //业务代码
		    impl.OperationImpl();  //调用实现类的方法
		    //业务代码
	    }
    }
}
