namespace MementoExtend
{
    internal class ChessmanMemento
    {
        private string label;
        private int x;
        private int y;

        internal string Label
        {
            get { return label; }
            set { label = value; }
        }

        internal int X
        {
            get { return x; }
            set { x = value; }
        }

        internal int Y
        {
            get { return y; }
            set { y = value; }
        }

        internal ChessmanMemento(string label, int x, int y)
        {
            this.label = label;
            this.x = x;
            this.y = y;
        }
    }
}
