using System;
namespace Calculator.Models
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public string Operation;

        public int Input1;
        public int Input2;
        public int Input3;

        public int CalculateResult()
        {
            int result = 0;

            if (Operation == "ADD")
            {
                result = Input1 + Input2 + Input3;
            }

            if (Operation == "SUBTRACT")
            {
                result = Input1 - Input2 - Input3;
            }

            return result;
        }
    }
}