using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public delegate void EventHandler();
    public class Boss:Subject
    {
        public event EventHandler Update;
        private string action;

        public void Notify()
        {
            Update();
        }

        public string SubjectState { get; set; }


    }
}
