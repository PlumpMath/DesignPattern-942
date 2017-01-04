using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class SubjectClass
    {

        private IList<Observer> observers = new List<Observer>();

        //增加观察者
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        //移除观察者
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// 通知
        /// </summary>
        public void Notify()
        {
            foreach (var item in observers)
            {
                item.Update();
            }
        }
    }
}
