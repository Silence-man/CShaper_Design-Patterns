using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preliminary
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder folder1, folder2, folder3;
            folder1 = new Folder("Sunny的资料");
            folder2 = new Folder("图像文件");
            folder3 = new Folder("文本文件");

            ImageFile image1, image2;
            image1 = new ImageFile("小龙女.jpg");
            image2 = new ImageFile("张无忌.gif");

            TextFile text1, text2;
            text1 = new TextFile("九阴真经.txt");
            text2 = new TextFile("葵花宝典.doc");

            folder2.addImageFile(image1);
            folder2.addImageFile(image2);
            folder3.addTextFile(text1);
            folder3.addTextFile(text2);
            folder1.addFolder(folder2);
            folder1.addFolder(folder3);

            folder1.killVirus();
            Console.ReadLine();
        }
        //图像文件类  
        class ImageFile
        {
            private String name;

            public ImageFile(String name)
            {
                this.name = name;
            }

            public void killVirus()
            {
                //简化代码，模拟杀毒  
                Console.WriteLine("----对图像文件'" + name + "'进行杀毒");
            }
        }

        //文本文件类  
        class TextFile
        {
            private String name;

            public TextFile(String name)
            {
                this.name = name;
            }

            public void killVirus()
            {
                //简化代码，模拟杀毒  
                Console.WriteLine("----对文本文件'" + name + "'进行杀毒");
            }
        }

        //文件夹类  
        class Folder
        {
            private String name;
            //定义集合folderList，用于存储Folder类型的成员  
            private List<Folder> folderList = new List<Folder>();
            //定义集合imageList，用于存储ImageFile类型的成员  
            private List<ImageFile> imageList = new List<ImageFile>();
            //定义集合textList，用于存储TextFile类型的成员  
            private List<TextFile> textList = new List<TextFile>();

            public Folder(String name)
            {
                this.name = name;
            }

            //增加新的Folder类型的成员  
            public void addFolder(Folder f)
            {
                folderList.Add(f);
            }

            //增加新的ImageFile类型的成员  
            public void addImageFile(ImageFile image)
            {
                imageList.Add(image);
            }

            //增加新的TextFile类型的成员  
            public void addTextFile(TextFile text)
            {
                textList.Add(text);
            }

            //需提供三个不同的方法removeFolder()、removeImageFile()和removeTextFile()来删除成员，代码省略  

            //需提供三个不同的方法getChildFolder(int i)、getChildImageFile(int i)和getChildTextFile(int i)来获取成员，代码省略  

            public void killVirus()
            {
                Console.WriteLine("****对文件夹'" + name + "'进行杀毒");  //模拟杀毒  

                //如果是Folder类型的成员，递归调用Folder的killVirus()方法  
                foreach (Object obj in folderList)
                {
                    ((Folder)obj).killVirus();
                }

                //如果是ImageFile类型的成员，调用ImageFile的killVirus()方法  
                foreach (Object obj in imageList)
                {
                    ((ImageFile)obj).killVirus();
                }

                //如果是TextFile类型的成员，调用TextFile的killVirus()方法  
                foreach (Object obj in textList)
                {
                    ((TextFile)obj).killVirus();
                }
            }
        }
    }
}
