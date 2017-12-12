namespace MementoExtend
{
    public class MementoCaretaker
    {
        private ChessmanMemento memento;

        internal ChessmanMemento GetMemento()
        {
            return memento;
        }

        internal void SetMemento(ChessmanMemento memento)
        {
            this.memento = memento;
        }
    }
}
