namespace Business.Operations
{
    public class AddOperation : OperationBase
    {
        public AddOperation(double value) : base("+", value)
        {
        }

        public override double CalculateResult(double input1)
        {
            return input1 + base.Value;
        }
    }
}