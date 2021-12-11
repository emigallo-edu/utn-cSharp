namespace Business.Operations
{
    public class MultiplyOperation : OperationBase
    {
        public MultiplyOperation(double value) : base("*", value)
        {

        }

        public override double CalculateResult(double input1)
        {
            double result = 0;

            for (int i = 1; i <= base.Value; i++)
            {
                result += input1;
            }

            return result;
        }
    }
}