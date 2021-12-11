namespace Business.Operations
{
    public class DivideOperation : OperationBase
    {
        public DivideOperation(double value) : base("/", value)
        {

        }

        public override double CalculateResult(double input1)
        {
            return input1 / base.Value;
        }
    }
}