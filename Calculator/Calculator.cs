using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator : ICalculable
    {
        private int PrimaryArg;

        public Calculator(int primaryArg)
        {
            PrimaryArg = primaryArg;
        }


        public ICalculable Sum(int arg)
        {
            PrimaryArg += arg;
            return this;
        }


        public ICalculable Multi(int arg)
        {
            PrimaryArg *= arg;
            return this;
        }


        public int GetResult()
        {
            return PrimaryArg;
        }
    }
}
