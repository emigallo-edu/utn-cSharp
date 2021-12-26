using System;
using System.Collections.Generic;
using Business.Operations;

namespace Business.Models
{
    public class ValueInput
    {
        public ValueInput(double value)
        {
            this.Value = value;
            this.Operations = new List<OperationBase>();
        }

        public double Value { get; init; }

        private List<OperationBase> Operations { get; init; }

        public void AddOperation(OperationBase op)
        {
            if (op == null)
            {
                throw new Exception("'op' no puede ser null.");
            }

            this.Operations.Add(op);
        }

        public List<OperationBase> GetOperations()
        {
            return this.Operations;
        }
    }
}


// 4
// +4
// /2
// *3

// 4
// 4+4
// 8/2
// 4*3