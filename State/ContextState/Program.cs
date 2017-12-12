using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextState
{
    class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen();
            screen.onClick();
            screen.onClick();
            screen.onClick();
        }
    }
}
