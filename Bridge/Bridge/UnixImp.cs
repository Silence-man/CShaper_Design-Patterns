using System;

namespace Bridge
{
    class UnixImp : ImageImp
    {
        public void DoPaint(Matrix m)
        {
            //调用Unix系统的绘制函数绘制像素矩阵
            Console.Write("在Unix操作系统中显示图像：");
        }
    }
}
