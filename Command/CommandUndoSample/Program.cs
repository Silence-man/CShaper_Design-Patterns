using System;

namespace CommandUndoSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            CalculatorForm form = new CalculatorForm();
            AbstractCommand command;
            command = new AddCommand();
            form.Command = command;

            form.Compute(10);
            form.Compute(5);
            form.Compute(10);
            form.Undo();

            Console.Read();
        }
    }
}
