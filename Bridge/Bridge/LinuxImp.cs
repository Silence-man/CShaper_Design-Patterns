//LinuxImp.cs
using System;

namespace Bridge
{
    class LinuxImp : ImageImp
    {
        public void DoPaint(Matrix m)
        {
            //调用Linux系统的绘制函数绘制像素矩阵
            Console.Write("在Linux操作系统中显示图像：");
        }
    }
}
