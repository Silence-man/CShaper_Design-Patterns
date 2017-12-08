namespace Command_Queue
{
    class ExitCommand : Command
    {
        private SystemExitClass seObj;

        public ExitCommand()
        {
            seObj = new SystemExitClass();
        }

        public override void Execute()
        {
            seObj.Exit();
        }
    }
}
