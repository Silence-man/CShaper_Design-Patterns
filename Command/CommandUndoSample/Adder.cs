namespace CommandUndoSample
{
    class Adder
    {
        private int num = 0;

        public int Add(int value)
        {
            num += value;
            return num;
        }
    }
}
