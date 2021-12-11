namespace Business.Operations
{
    public abstract class OperationBase
    {
        public OperationBase(string symbol, double value)
        {
            this.Symbol = symbol;
            this.Value = value;
        }

        public abstract double CalculateResult(double input1);
        public double Value { get; private set; }

        public string Symbol { get; private set; }
    }
}