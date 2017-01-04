using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class FlyweightFactory
    {
        private Hashtable flyweights = new Hashtable();

        public Flyweight GetFlyweight(string key)
        {
            if (!flyweights.ContainsKey(key))
                flyweights.Add(key, new ConcreteFlyweight(key));
           
            return (Flyweight)flyweights[key];
        }
    }
}
