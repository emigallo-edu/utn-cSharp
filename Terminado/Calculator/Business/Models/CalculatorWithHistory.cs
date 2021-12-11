using System.Linq;
using Business.Operations;

namespace Business.Models
{
    public class CalculatorWithHistory
    {
        public CalculatorWithHistory()
        {

        }

        public ValueInput Input { get; private set; }

        public void AddInput(double value)
        {
            this.Input = new ValueInput(value);
        }

        public void AddInput(OperationBase operation)
        {
            this.Input.Operations.Add(operation);
        }

        public double Do()
        {
            double result = this.Input.Value;

            foreach (OperationBase operation in this.Input.Operations)
            {
                result = operation.CalculateResult(result);
            }

            return result;
        }

        public string GetInputs()
        {
            string rett = string.Format("{0}", this.Input.Value);

            foreach (OperationBase item in this.Input.Operations)
            {
                rett += string.Format(" {0} {1}", item.Symbol, item.Value);
            }

            return rett;
        }

        public string GetOnlyAddOperationInputs()
        {
            string rett = string.Format("{0}", this.Input.Value);

            foreach (OperationBase item in this.Input.Operations.Where(x => x.GetType() == typeof(AddOperation)))
            {
                rett += string.Format(" {0} {1}", item.Symbol, item.Value);
            }

            return rett;
        }
    }
}