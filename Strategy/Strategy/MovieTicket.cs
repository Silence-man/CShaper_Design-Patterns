using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //电影票类  
    class MovieTicket
    {
        private double price; //电影票价格  
        private String type; //电影票类型  

        public void setPrice(double price)
        {
            this.price = price;
        }

        public void setType(String type)
        {
            this.type = type;
        }

        public double getPrice()
        {
            return this.calculate();
        }

        //计算打折之后的票价  
        public double calculate()
        {
            //学生票折后票价计算  
            if (this.type.Equals("student"))
            {
                Console.WriteLine("学生票：");
                return this.price * 0.8;
            }
            //儿童票折后票价计算  
            else if (this.type.Equals("children") && this.price >= 20)
            {
                Console.WriteLine("儿童票：");
                return this.price - 10;
            }
            //VIP票折后票价计算  
            else if (this.type.Equals("vip"))
            {
                Console.WriteLine("VIP票：");
                Console.WriteLine("增加积分！");
                return this.price * 0.5;
            }
            else
            {
                return this.price; //如果不满足任何打折要求，则返回原始票价  
            }
        }
    }
}
