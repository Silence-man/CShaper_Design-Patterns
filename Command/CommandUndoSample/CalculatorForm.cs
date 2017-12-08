using System;

namespace CommandUndoSample
{
    class CalculatorForm
    {
        private AbstractCommand command;

        public AbstractCommand Command
        {
            get { return command; }
            set { command = value; }
        }

        public void Compute(int value)
        {
            int i = Command.Execute(value);
            Console.WriteLine("执行运算，运算结果为：" + i);
        }

        public void Undo()
        {
            int i = Command.Undo();
            Console.WriteLine("执行撤销，运算结果为：" + i);
        }
    }
}
