using Business.Models;
using Business.Operations;
using Business.Utils;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorWithHistory calc = new CalculatorWithHistory();
          

            calc.Add(4);
            OperationBase add = new AddOperation(3.3);
            calc.Add(add);
            System.Console.WriteLine(add.GetInput());

            OperationBase mult = new MultiplyOperation(2.4);
            calc.Add(mult);
            System.Console.WriteLine(mult.GetInput());

            double result = calc.Do();
            System.Console.WriteLine(result);

            calc.Copy();

            System.Console.WriteLine("Contains " + calc.ContainsOperation(new AddOperation(3.3)));
        }

        //private static double CalculateResultAndShowInConsole(double val1, double val2, OperationBase op)
        //{
        //    //Calculator calc = new Calculator();

        //    //double result = calc.CalculateResult(val1, val2, op);
        //    //System.Console.WriteLine(result);

        //    //return result;
        //}
    }
}