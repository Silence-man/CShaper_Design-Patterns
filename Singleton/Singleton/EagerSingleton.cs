using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class EagerSingleton
    {
        private static  EagerSingleton instance = new EagerSingleton();
        private EagerSingleton()
        { }

        public static EagerSingleton getInstance()
        {
            return instance;
        }
    }
}
