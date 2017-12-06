using System;
using System.Collections.Generic;

namespace Composite
{
    class Folder : AbstractFile 
    {
	    //定义集合fileList，用于存储AbstractFile类型的成员
	    private List<AbstractFile> fileList = new List<AbstractFile>();
	    private string name;
		
	    public Folder(string name) 
        {
		    this.name = name;
	    }

        public override void Add(AbstractFile file)
        {
	       fileList.Add(file);	
	    }

        public override void Remove(AbstractFile file)
        {
		    fileList.Remove(file);
	    }

        public override AbstractFile GetChild(int i)
        {
		    return (AbstractFile)fileList[i];
	    }
	
	    public override void KillVirus() 
        {
		    Console.WriteLine("****对文件夹'{0}'进行杀毒",name);  //模拟杀毒
		
		    //递归调用成员构件的killVirus()方法
		    foreach(Object obj in fileList) 
            {
			    ((AbstractFile)obj).KillVirus();
		    }
	    }
    }
}
