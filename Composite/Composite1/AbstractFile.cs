using System;

namespace Composite
{
    abstract class AbstractFile
    {
        //由AbstractFile提供统一的默认实现
        public virtual void Add(AbstractFile file)
        {
            Console.WriteLine("对不起，不支持该方法！");
        }

        public virtual void Remove(AbstractFile file)
        {
            Console.WriteLine("对不起，不支持该方法！");
        }

        public virtual AbstractFile GetChild(int i)
        {
            Console.WriteLine("对不起，不支持该方法！");
            return null;
        }

        public abstract void KillVirus();
    }
}
