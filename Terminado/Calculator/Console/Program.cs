﻿using Business.Models;
using Business.Operations;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorWithHistory calc = new CalculatorWithHistory();

            calc.Add(7);
            calc.Add(new AddOperation(4));
            // System.Console.WriteLine("4 + 7 = " + calc.Do());

            calc.Add(new SubtractOperation(2));
            // System.Console.WriteLine("11 - 2 = " + calc.Do());

            // System.Console.WriteLine("Inputs: " + calc.GetInputs());
            // System.Console.WriteLine("Inputs: " + calc.GetOnlyAddOperationInputs());


            System.Console.WriteLine("Contains " + calc.ContainsOperation(new SubtractOperation(2)));
        }
    }
}