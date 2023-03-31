using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorView
    {
        public CalculatorView(ICalculableFactory calculableFactory)
        {
            CalculableFactory = calculableFactory;
        }

        ICalculableFactory CalculableFactory { set; get; }

        public void Run()
        {
            while (true)
            {
                int primaryArg = PromptInt("Enter first arg: ");
                ICalculable calculator = CalculableFactory.Create(primaryArg);
                string cmd;
                while (true)
                {
                    cmd = PromptStr("Enter the command (*, +, =) :");
                    if (cmd.Equals("*"))
                    {
                        int arg = PromptInt("Enter more arg: ");
                        calculator.Multi(arg);
                        continue;
                    }
                    if (cmd.Equals("+"))
                    {
                        int arg = PromptInt("Enter more arg: ");
                        calculator.Sum(arg);
                        continue;
                    }
                    if (cmd.Equals("="))
                    {
                        int result = calculator.GetResult();
                        Console.WriteLine($"Result is {result}");
                        break;
                    }
                }
                cmd = PromptStr("Continue (Y/N)?");
                if (cmd.ToUpper().Equals("Y"))
                {
                    continue;
                }
                break;
            }
        }

        string PromptStr(string message)
        {
            Console.WriteLine(message);
            string ansver = Console.ReadLine();
            return ansver;
        }

        int PromptInt(string message)
        {
            return int.Parse(PromptStr(message));
        }
    }
}
