using System;

namespace Composite
{
    class VideoFile : AbstractFile
    {
        private string name;

        public VideoFile(string name)
        {
            this.name = name;
        }


        public override void KillVirus()
        {
            //模拟杀毒
            Console.WriteLine("----对视频文件'{0}'进行杀毒",name);
        }
    }
}