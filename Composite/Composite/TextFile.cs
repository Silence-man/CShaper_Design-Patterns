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

        public override void Add(AbstractFile file)
        {
            Console.WriteLine("对不起，不支持该方法！");
        }

        public override void Remove(AbstractFile file)
        {
            Console.WriteLine("对不起，不支持该方法！");
        }

        public override AbstractFile GetChild(int i)
        {
            Console.WriteLine("对不起，不支持该方法！");
            return null;
        }

        public override void KillVirus()
        {
            //模拟杀毒
            Console.WriteLine("----对文本文件'{0}'进行杀毒",name);
        }
    }
}