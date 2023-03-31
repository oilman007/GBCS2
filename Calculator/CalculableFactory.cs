using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculableFactory : ICalculableFactory
    {
        public virtual ICalculable Create(int primaryArg)
        {
            return new Calculator(primaryArg);
        }
    }
}
