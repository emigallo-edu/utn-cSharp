using System;
namespace Business.Operations
{
    public class MultiplyOperation : OperationBase
    {
        public MultiplyOperation()
        {
            this.OperationId = "*";
        }

        public override double CalculateResult(double input1, double input2)
        {
            return input1 * input2;
        }

        public override string OperationId { get; }
    }
}
