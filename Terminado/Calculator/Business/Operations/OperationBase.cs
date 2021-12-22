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

        public override bool Equals(object obj)
        {
            OperationBase item = obj as OperationBase;
            return this.Symbol == item.Symbol && this.Value == item.Value;
        }
    }
}