using System;
namespace Business.Operations
{
    public abstract class OperationBase
    {
        public OperationBase()
        {
        }

        public abstract double CalculateResult(double input1, double input2);

        public abstract string OperationId { get; }
    }
}