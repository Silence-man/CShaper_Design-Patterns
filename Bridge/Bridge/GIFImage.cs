using System;

namespace Bridge
{
    class GIFImage : Image
    {
        public override void ParseFile(string fileName)
        {
            //模拟解析GIF文件并获得一个像素矩阵对象m;
            Matrix m = new Matrix(); 
            imp.DoPaint(m);
            Console.WriteLine("{0}，格式为GIF。", fileName);
        }
    }
}
