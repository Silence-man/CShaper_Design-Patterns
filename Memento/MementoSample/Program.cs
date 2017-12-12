using System;

namespace MementoExtend
{
    class Program
    {
        public static void Display(Chessman chess) 
        {
		   Console.WriteLine("棋子{0}的当前位置为：第{1}行第{2}列。",chess.Label, chess.X, chess.Y);
	    }

        static void Main(string[] args)
        {
          
            MementoCaretaker mc = new MementoCaretaker();
		    Chessman chess = new Chessman("车",1,1);
		    Display(chess);
		    mc.SetMemento(chess.Save()); //保存状态		
		    chess.Y = 4;
		    Display(chess);
		    mc.SetMemento(chess.Save()); //保存状态
		    Display(chess);
		    chess.X = 5;
		    Display(chess);
		    Console.WriteLine("******悔棋******");	
		    chess.Restore(mc.GetMemento()); //恢复状态
		    Display(chess);

            Console.Read();
        }
    }
}
