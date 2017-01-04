using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Context
    {
        Strategy _strategy;

        //public Context(Strategy strategy)
        //{
        //    this._strategy = strategy;
        //}

        //public void ContextInterface()
        //{
        //    _strategy.AlgorithmInterface();
        //}

        public Context(string type)
        {
            switch (type)
            {
                case "正常收费":
                    ConcerteStrategyA ca = new ConcerteStrategyA();
                    _strategy = ca;
                    break;
                case "满100送10":
                    ConcerteStrategyB cb = new ConcerteStrategyB();
                    _strategy = cb;
                    break;
            }
        }

        public double GetResult(double money)
        {
            return _strategy.AlgorithmInterface(money);
        }
    }
}
