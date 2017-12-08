namespace Command_Queue
{
    class HelpCommand : Command
    {
        private DisplayHelpClass hcObj;

        public HelpCommand()
        {
            hcObj = new DisplayHelpClass();
        }

        public override void Execute()
        {
            hcObj.Display();
        }
    }
}
