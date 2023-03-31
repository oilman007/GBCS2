using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Factory : ICalculableFactory
    {
        public ICalculable Create(int primaryArg)
        {
            return new CalculatorLog(primaryArg, new Log());
        }
    }
}
