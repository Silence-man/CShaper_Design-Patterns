using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
          Originator ori = new Originator("状态(1)");
          Console.WriteLine(ori.GetState());

          Caretaker ct = new Caretaker();
          ct.SetMemento(ori.CreateMemento());

          ori.SetState("状态(2)");
          Console.WriteLine(ori.GetState());

          ori.RestoreMemento(ct.GetMemento());
          Console.WriteLine(ori.GetState());
     
        }
    }
}
