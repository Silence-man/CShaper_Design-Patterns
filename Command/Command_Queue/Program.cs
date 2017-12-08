using System;
using System.Configuration;
using System.Reflection;

namespace Command_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandQueue cmdqueue = new CommandQueue();

            Command command1 = new HelpCommand();
            Command command2 = new ExitCommand();
            cmdqueue.AddCommand(command1);
            cmdqueue.AddCommand(command2);

            Invoker invoker = new Invoker(cmdqueue);
            invoker.Call();
            Console.Read();
        }
    }
}
