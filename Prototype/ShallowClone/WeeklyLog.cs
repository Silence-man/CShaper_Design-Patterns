using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowClone
{
    class WeeklyLog:ICloneable
    {
        private Attachment attachment;
        private string name;
        private string date;
        private string content;

        public Attachment Attachment
        {
            get { return attachment; }
            set { attachment = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public object Clone()
        {
            return this.MemberwiseClone(); //客户端进行类型转换
        }


        //使用MemberwiseClone()方法实现浅克隆
        //public WeeklyLog Clone()
        //{
        //     return this.MemberwiseClone() as WeeklyLog;
        //}

    }
}
