using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderTemplate
{
    class Product
    {
        private string partA; //定义部件，部件可以是任意类型，包括值类型和引用类型
        private string partB;
        private string partC;

        public string PartA
        {
            get { return partA; }
            set { partA = value; }
        }

        public string PartB
        {
            get { return partB; }
            set { partB = value; }
        }

        public string PartC
        {
            get { return partC; }
            set { partC = value; }
        }
    }

    abstract class Builder
    {
        //创建产品对象
        protected Product product = new Product();

        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();

        //返回产品对象
        public Product GetResult()
        {
            return product;
        }
    }

    class ConcreteBuilder1 : Builder
    {
        public override void BuildPartA()
        {
            product.PartA = "A1";
        }

        public override void BuildPartB()
        {
            product.PartB = "B1";
        }

        public override void BuildPartC()
        {
            product.PartC = "C1";
        }
    }

    class Director
    {
        private Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void SetBuilder(Builder builder)
        {
            this.builder = builder;
        }

        //产品构建与组装方法
        public Product Construct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
            return builder.GetResult();
        }
    }
}
