using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class ConcreteFlyweight : Flyweight
    {
        private string key;

        public ConcreteFlyweight(string key)
        {
            this.key = key;
        }

        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("具体 Flyweight:"+extrinsicstate); 
        }
    }
}
