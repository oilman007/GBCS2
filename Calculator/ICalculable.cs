using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ICalculable
    {
        public ICalculable Sum(int arg);
        public ICalculable Multi(int arg);
        public int GetResult();
    }
}
