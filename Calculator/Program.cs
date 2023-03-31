// See https://aka.ms/new-console-template for more information
using Calculator;

//Console.WriteLine("Hello, World!");



ICalculableFactory calculableFactory = new Factory();
CalculatorView view = new CalculatorView(calculableFactory);
view.Run();
