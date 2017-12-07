using System.Collections;

namespace FlyweightSample
{
    class IgoChessmanFactory
    {
        private static IgoChessmanFactory instance = new IgoChessmanFactory();
        private Hashtable ht; //使用Hashtable来存储享元对象，充当享元池

        private IgoChessmanFactory()
        {
            ht = new Hashtable();
            IgoChessman black, white;
            black = new BlackIgoChessman();
            ht.Add("b", black);
            white = new WhiteIgoChessman();
            ht.Add("w", white);
        }

        //返回享元工厂类的唯一实例
        public static IgoChessmanFactory GetInstance()
        {
            return instance;
        }

        //通过key来获取存储在Hashtable中的享元对象
        public IgoChessman GetIgoChessman(string color)
        {
            return (IgoChessman)ht[color];
        }
    }
}