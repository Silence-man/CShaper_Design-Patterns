namespace CommandUndoSample
{
    class AddCommand : AbstractCommand
    {
        private Adder adder = new Adder();
        private int value;

        public override int Execute(int value)
        {
            this.value = value;
            return adder.Add(value);
        }

        public override int Undo()
        {
            return adder.Add(-value);
        }
    }
}
