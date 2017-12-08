using System.Collections.Generic;

namespace CommandSample
{
    class CommandQueue
    {
        //定义一个List来存储命令队列
        private List<Command> commands = new List<Command>();

        public void AddCommand(Command command)
        {
            commands.Add(command);
        }

        public void RemoveCommand(Command command)
        {
            commands.Remove(command);
        }

        //循环调用每一个命令对象的Execute()方法
        public void Execute() 
        {
		    foreach (object command in commands) 
            {
			    ((Command)command).Execute();
		    }
	    }
    }
}
