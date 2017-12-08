namespace CoRSample
{
    abstract class Approver
    {
        protected Approver successor; //定义后继对象
        protected string name; //审批者姓名

        public Approver(string name)
        {
            this.name = name;
        }

        //设置后继者
        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }

        //抽象请求处理方法
        public abstract void ProcessRequest(PurchaseRequest request);
    }
}
