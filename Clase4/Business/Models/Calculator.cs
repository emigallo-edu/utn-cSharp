using System;
using System.Collections.Generic;
using System.Linq;
using Business.Operations;

namespace Business.Models
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public enum Operations
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        public double CalculateResult(double val1, double val2, OperationBase operation)
        {
            return operation.CalculateResult(val1, val2);
        }

        //double Do(double val1, double val2, Operations operation)
        //{
        //    if (operation == Operations.Add)
        //    {
        //        return val1 + val2;
        //    }

        //    if (operation == Operations.Divide)
        //    {
        //        if (val2 == 0)
        //        {
        //            throw new Exception("No se puede dividir por 0.");
        //        }

        //        return val1 / val2;
        //    }

        //    if (operation == Operations.Subtract)
        //    {
        //        return val1 - val2;
        //    }

        //    if (operation == Operations.Multiply)
        //    {
        //        return val1 * val2;
        //    }

        //    throw new Exception("Operación no soportada por el sistema.");
        //}

        //float Do(List<string> items)
        //{
        //    items.Add("hola");
        //    items.Add("+");
        //    items.Add("8");

        //    double val = double.Parse(items.First());

        //    // 4+3-2*8
        //}
    }
}