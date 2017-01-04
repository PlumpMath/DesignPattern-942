using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Resume : ICloneable
    {
        public string Name;
        public string Sex;
        public int Age;
        //public string TimeArea;
        //public string Company;

        public WorkExperience work;

        public Resume(string name)
        {
            this.Name = name;
            this.work = new WorkExperience();
        }

        private Resume(WorkExperience work)
        {
            this.work = (WorkExperience)work.Clone();
        }

        public void SetPersonallInfo(string sex, int age)
        {
            this.Age = age;
            this.Sex = sex;
        }

        public void SetWorkExperience(string timeArea, string company)
        {
            //this.TimeArea = timeArea;
            //this.Company = company;

            work.WorkDate = timeArea;
            work.Company = company;
        }


        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", this.Name, this.Sex, this.Age);
            Console.WriteLine("工作经历:{0} {1}", work.WorkDate, work.Company);
        }

        public object Clone()
        {
            //return (object)this.MemberwiseClone();
            Resume obj = new Resume(work);
            obj.Name = this.Name;
            obj.Sex = this.Sex;
            obj.Age = this.Age;
            return obj;

        }



    }
}
