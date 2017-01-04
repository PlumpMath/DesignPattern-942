using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;


        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\n方法组A() ----");
            one.MethodOne();
            two.MethodTwo();
            three.MethodThree();
            four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("\n 方法组B() ----");
            two.MethodTwo();
            three.MethodThree();
        }
    }
}
