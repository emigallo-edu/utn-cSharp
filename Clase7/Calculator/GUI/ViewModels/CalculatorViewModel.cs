using Business.Models;
using Business.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GUI.ViewModels
{
    class CalculatorViewModel : INotifyPropertyChanged
    {
        private Boolean _firstValue;
        private CalculatorWithHistory _calculator;

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion INotifyPropertyChanged

        public CalculatorViewModel()
        {
            this.ClearResult();
        }

        public void CalculateResult()
        {
            this.Result = this._calculator.Do();
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
            if (this._firstValue)
            {
                this._firstValue = false;
                this._calculator.Add(0);
            }

            this._calculator.Add(op);
        }

        private double _result;
        public double Result
        {
            get
            {
                return this._result;
            }
            set
            {
                this._result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        internal void ClearResult()
        {
            this.Result = 0;
            this._calculator = new CalculatorWithHistory();
            this._firstValue = true;
        }
    }
}