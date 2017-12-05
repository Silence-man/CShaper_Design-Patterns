using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class WeeklyLog:ICloneable
    {
        private String name;
        private String date;
        private String content;
        public void setName(String name)
        {
            this.name = name;
        }
        public void setDate(String date)
        {
            this.date = date;
        }
        public void setContent(String content)
        {
            this.content = content;
        }
        public String getName()
        {
            return (this.name);
        }
        public String getDate()
        {
            return (this.date);
        }
        public String getContent()
        {
            return (this.content);
        }
        //克隆方法clone()，此处使用C#语言提供的克隆机制

        public Object Clone()
        {
            WeeklyLog obj = new Prototype.WeeklyLog ();
            try
            {
               
                obj.name = this.name;
                obj.date = this.date;
                obj.content = this.content;
                return (Object)obj;
            }
            catch
            {
                Console.WriteLine("不支持复制！");
                return null;
            }
        }
    }
}
