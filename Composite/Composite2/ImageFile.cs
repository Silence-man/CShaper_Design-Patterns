using System;

namespace Composite
{
    class ImageFile : AbstractFile 
    {
	    private string name;
	
	    public ImageFile(string name) 
        {
		    this.name = name;
	    }
	  
	    public override void KillVirus() 
        {
		    //模拟杀毒
            Console.WriteLine("----对图像文件'{0}'进行杀毒",name);
	    }
    }
}