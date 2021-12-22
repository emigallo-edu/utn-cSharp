using System;
namespace Business.Operations
{
    public class AddOperation : OperationBase
    {
        public AddOperation()
        {
            this.OperationId = "+";
        }

        public override string OperationId { get; }

        public override double CalculateResult(double input1, double input2)
        {
            return input1 + input2;
        }
    }
}