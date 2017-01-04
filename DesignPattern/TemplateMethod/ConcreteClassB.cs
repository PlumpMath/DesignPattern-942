using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("具体类B方法实现一");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("具体类B方法实现二");
        }
    }
}
