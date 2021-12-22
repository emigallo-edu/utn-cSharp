using System;
using Business.Models;
using Business.Operations;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            OperationBase op = new SubtractOperation();

            calc.CalculateResult(3, 4, op);


            System.Console.WriteLine(op.OperationId);
        }
    }
}