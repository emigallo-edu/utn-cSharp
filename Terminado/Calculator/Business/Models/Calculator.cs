using Business.Operations;

namespace Business.Models
{
    public class Calculator
    {
        public OperationBase Operation { get; set; }
        public double Input1 { get; set; }
        public double Input2 { get; set; }

        public double Do()
        {
            double result = this.Operation.CalculateResult(this.Input1);
            return result;
        }
    }

    public class Auto
    {
        private int _cambioActual;

        public string Color { get; set; }

        public Auto()
        {

        }

        public void Encender()
        {

        }
    }
}