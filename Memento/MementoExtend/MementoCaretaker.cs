using System.Collections;

namespace MementoExtend
{
    public class MementoCaretaker
    {
        //定义一个集合来存储多个备忘录
        private ArrayList mementolist = new ArrayList();

        internal ChessmanMemento GetMemento(int i)
        {
            return (ChessmanMemento)mementolist[i];
        }

        internal void SetMemento(ChessmanMemento memento)
        {
            mementolist.Add(memento);
        }
    }
}
