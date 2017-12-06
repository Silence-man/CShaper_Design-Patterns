using System;

namespace Composite
{
    class TextFile : AbstractFile
    {
        private string name;

        public TextFile(string name)
        {
            this.name = name;
        }

        public override void KillVirus()
        {
            //模拟杀毒
            Console.WriteLine("----对文本文件'{0}'进行杀毒",name);
        }
    }
}