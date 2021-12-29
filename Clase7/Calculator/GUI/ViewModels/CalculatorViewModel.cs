using Business.Models;
using Business.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.ViewModels
{
    class CalculatorViewModel
    {
        private Boolean _firstValue;
        private CalculatorWithHistory _calculator;

        public CalculatorViewModel()
        {
            this._calculator = new CalculatorWithHistory();
            this._firstValue = true;
        }

        //calc.Add(4);
        //OperationBase add = new AddOperation(3.3);
        //calc.Add(add);

        public double CalculateResult()
        {
            return this._calculator.Do();
        }

        public void AddValue(double value)
        {
            if (this._firstValue)
            {
                this._firstValue = false;
                this._calculator.Add(value);
            }
            else
            {
                // Obtener la última operación y asignarle el valor ingresado
                this._calculator.AddValueToLastOperation(value);
            }
        }

        public void AddOperation(OperationBase op)
        {
            this._calculator.Add(op);
        }
    }
}