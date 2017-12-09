namespace ObserverSample
{
    interface IObserver
    {
        string Name
        {
            get;
            set;
        }
        void Help(); //声明支援盟友方法
        void BeAttacked(AllyControlCenter acc); //声明遭受攻击方法
    }
}