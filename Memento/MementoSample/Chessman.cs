namespace MementoExtend
{
    class Chessman
    {
        private string label;
        private int x;
        private int y;

        public string Label
        {
            get { return label; }
            set { label = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Chessman(string label, int x, int y)
        {
            this.label = label;
            this.x = x;
            this.y = y;
        }
        
        //保存状态
	    internal ChessmanMemento Save() 
        {
		    return new ChessmanMemento(this.Label,this.X,this.Y);
	    }
	
        //恢复状态
        internal void Restore(ChessmanMemento memento) 
        {
		    this.Label = memento.Label;
		    this.X = memento.X;
		    this.Y = memento.Y;
	    }
    }
}
