using System;
using Business.Operations;

namespace Business.Models
{
    public class Calculator
    {
        public enum Operations
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        //public double CalculateResult(double val1, double val2, OperationBase operation)
        //{
        //    return operation.CalculateResult(val1, val2);
        //}

        /// <summary>
        /// 2da versión, dónde el método resuelve toda la lógica
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        double CalculateResult_2(double val1, double val2, OperationBase operation)
        {
            if (operation is AddOperation)
            {
                return val1 + val2;
            }

            if (operation is DivideOperation)
            {
                if (val2 == 0)
                {
                    throw new Exception("No se puede dividir por 0.");
                }

                return val1 / val2;
            }

            if (operation is SubtractOperation)
            {
                return val1 - val2;
            }

            if (operation is MultiplyOperation)
            {
                return val1 * val2;
            }

            throw new Exception("Operación no soportada por el sistema.");
        }

        /// <summary>
        /// 1ra versión, dónde el método resuelve toda la lógica
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        double CalculateResult_1(double val1, double val2, Operations operation)
        {
            if (operation == Operations.Add)
            {
                return val1 + val2;
            }

            if (operation == Operations.Divide)
            {
                if (val2 == 0)
                {
                    throw new Exception("No se puede dividir por 0.");
                }

                return val1 / val2;
            }

            if (operation == Operations.Subtract)
            {
                return val1 - val2;
            }

            if (operation == Operations.Multiply)
            {
                return val1 * val2;
            }

            throw new Exception("Operación no soportada por el sistema.");
        }
    }
}