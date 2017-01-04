using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ConcreteVisitorB : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElement)
        {
            Console.WriteLine("{0} 被 {1} 访问", concreteElement.GetType().Name, this.GetType().Name);
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElement)
        {
            Console.WriteLine("{0} 被 {1} 访问", concreteElement.GetType().Name, this.GetType().Name);
        }
    }
}
