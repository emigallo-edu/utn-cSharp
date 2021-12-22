namespace Business.Operations
{
    public class MultiplyOperation : OperationBase
    {
        public MultiplyOperation(double value) : base("*", value)
        {
        }

        public override double CalculateResult(double input1)
        {
            return input1 * this.Value;
        }
    }
}