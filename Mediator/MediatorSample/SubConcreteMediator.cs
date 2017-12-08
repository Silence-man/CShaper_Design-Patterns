using System;

namespace MediatorSample
{
    class SubConcreteMediator : ConcreteMediator
    {
        //增加对Label对象的引用
        public Label label;

        public override void ComponentChanged(Component c) 
        {
	        //单击按钮
            if (c == addButton) 
            {
			    Console.WriteLine("--单击增加按钮--");
			    list.Update();
			    cb.Update();
			    userNameTextBox.Update();
			    label.Update(); //文本标签更新
		    }
            //从列表框选择客户
		    else if (c == list) 
            {
			    Console.WriteLine("--从列表框选择客户--");
			    cb.Select();
			    userNameTextBox.SetText();
		    }
            //从组合框选择客户
		    else if (c == cb) 
            {
                Console.WriteLine("--从组合框选择客户--");
			    cb.Select();
			    userNameTextBox.SetText();
		    }
	    }
    }
}
