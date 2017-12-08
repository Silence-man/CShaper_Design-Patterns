using System;

namespace CommandSample
{
    class FunctionButton
    {
        private Command command;

        public Command Command
        {
            get { return command; }
            set { command = value; }
        }

        public void Click()
        {
            Console.WriteLine("单击功能键！");
            command.Execute();
        }
    }
}
