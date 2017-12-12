using System;

namespace MementoExtend
{
    class Program
    {
        private static int index = -1; //定义一个索引来记录当前状态所在位置
        private static MementoCaretaker mc = new MementoCaretaker();

        static void Main(string[] args)
        {
            Chessman chess = new Chessman("车", 1, 1);
            Play(chess);
            chess.Y = 4;
            Play(chess);
            chess.X = 5;
            Play(chess);
            Undo(chess, index);
            Undo(chess, index);
            Redo(chess, index);
            Redo(chess, index);

            Console.Read();
        }

        //下棋
        public static void Play(Chessman chess) 
        {
		    mc.SetMemento(chess.Save()); //保存备忘录
		    index ++; 
		    Console.WriteLine("棋子{0}当前位置为：第{1}行第{2}列。",chess.Label, chess.X, chess.Y);
	    }

        //悔棋
        public static void Undo(Chessman chess, int i) 
        {
		    Console.WriteLine("******悔棋******");
		    index --; 
		    chess.Restore(mc.GetMemento(i-1)); //撤销到上一个备忘录
            Console.WriteLine("棋子{0}当前位置为：第{1}行第{2}列。", chess.Label, chess.X, chess.Y);
	    }

        //撤销悔棋
        public static void Redo(Chessman chess, int i) 
        {
		    Console.WriteLine("******撤销悔棋******");	
		    index ++; 
		    chess.Restore(mc.GetMemento(i+1)); //恢复到下一个备忘录
            Console.WriteLine("棋子{0}当前位置为：第{1}行第{2}列。", chess.Label, chess.X, chess.Y);
	    }
    }
}
