using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeManagerSample
{
    abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    class ConcretePrototypeA : Prototype
    {
        public override Prototype Clone()
        {
            return (ConcretePrototypeA)this.MemberwiseClone();
        }
    }

    class ConcretePrototypeB : Prototype
    {
        public override Prototype Clone()
        {
            return (ConcretePrototypeB)this.MemberwiseClone();
        }
    }

    class PrototypeManager
    {
        Hashtable ht = new Hashtable();
        public PrototypeManager()
        {
            ht.Add("A", new ConcretePrototypeA());
            ht.Add("B", new ConcretePrototypeB());
        }

        public void Add(string key, Prototype prototype)
        {
            ht.Add(key, prototype);
        }

        public Prototype Get(string key)
        {
            Prototype clone = null;
            clone = ((Prototype)ht[key]).Clone();
            return clone;
        }
    }
}