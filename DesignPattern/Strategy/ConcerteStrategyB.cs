using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class ConcerteStrategyB : Strategy
    {
        public override double AlgorithmInterface(double money)
        {
            // Console.WriteLine("算法B");
            return money * 5;
        }
    }
}
