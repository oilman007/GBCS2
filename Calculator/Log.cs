using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Log : ILoggable
    {
        public Log()
        {
        }
        public void Call(string message)
        {
            Console.WriteLine("log: " + message);
        }
    }
}
