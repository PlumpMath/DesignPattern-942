using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ConcerteStrategyA : Strategy
    {
        public override double AlgorithmInterface(double money)
        {
            //Console.WriteLine("算法A实现");
            return money * 5;
        }
    }
}
