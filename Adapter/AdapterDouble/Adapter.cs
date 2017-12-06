using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDouble
{
    class Adapter:Target, Adaptee {  
    //同时维持对抽象目标类和适配者的引用  
    private Target target;
    private Adaptee adaptee;

    public Adapter(Target target)
    {
        this.target = target;
    }

    public Adapter(Adaptee adaptee)
    {
        this.adaptee = adaptee;
    }

    public void request()
    {
        adaptee.specificRequest();
    }

    public void specificRequest()
    {
        target.request();
    }
}  
}
