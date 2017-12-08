namespace CommandUndoSample
{
    abstract class AbstractCommand
    {
        public abstract int Execute(int value);
        public abstract int Undo();
    }
}
