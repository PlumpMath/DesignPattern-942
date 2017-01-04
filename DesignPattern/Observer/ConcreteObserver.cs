using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ConcreteObserver : Observer
    {
        private string name;
        private ConcreteSubject subject;
        private string observerState;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.name = name;
            this.subject = subject;
        }

        public override void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine("观察者{0}的新状态是{1}", name, observerState);
        }

        public ConcreteSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
}
