using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ConcreteMediator : Mediator
    {
        private ConcreteColleagueA colleagueA;
        private ConcreteColleagueB colleagueB;

        public ConcreteColleagueA ColleagueA
        {
            set{ colleagueA = value; }
        }

        public ConcreteColleagueB ColleagueB
        {
            set { colleagueB = value; }
        }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == colleagueA)
                colleagueB.Notify(message);
            else
                colleagueA.Notify(message);
        }
    }
}
