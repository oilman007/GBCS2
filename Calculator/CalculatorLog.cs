using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorLog : ICalculable
    {
        int PrimaryArg { set; get; }
        Log Logger { set; get; }

        public CalculatorLog(int primaryArg, Log logger)
        {
            Logger = logger;
            PrimaryArg = primaryArg;
            Logger.Call(PrimaryArg.ToString());
        }



        public ICalculable Sum(int arg)
        {
            Logger.Call(arg.ToString());
            PrimaryArg += arg;
            return this;
        }


        public ICalculable Multi(int arg)
        {
            Logger.Call(arg.ToString());
            PrimaryArg *= arg;
            return this;
        }

        public int GetResult()
        {
            Logger.Call(PrimaryArg.ToString());
            return PrimaryArg;
        }
    }
}
