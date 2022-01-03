using Business.Operations;
using GUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace GUI.Views
{
    public partial class CalculatorView : Window
    {
        private CalculatorViewModel _vm;
        private Dictionary<string, Func<OperationBase>> _operations;

        public CalculatorView()
        {
            InitializeComponent();
            this._vm = new CalculatorViewModel();
            DataContext = this._vm;

            this._operations = new Dictionary<string, Func<OperationBase>>();
            this._operations.Add("+", () => new AddOperation());
            this._operations.Add("OemPlus", () => new AddOperation());
            this._operations.Add("-", () => new SubtractOperation());
            this._operations.Add("OemMinus", () => new SubtractOperation());
            this._operations.Add("X", () => new MultiplyOperation());
            this._operations.Add("/", () => new DivideOperation());
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            this._vm.CalculateResult();
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            int value = int.Parse(button.Content.ToString());
            this._vm.AddValue(value);
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string key = button.Content.ToString();

            OperationBase op = this._operations[key].Invoke();
            this._vm.AddOperation(op);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            this._vm.ClearResult();
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            string key = e.Key.ToString();

            if (key == "Escape")
            {
                this._vm.ClearResult();
            }

            if (key.Substring(0, 1) == "D")
            {
                int value = int.Parse(key.Substring(1));
                this._vm.AddValue(value);
            }

            if (this._operations.ContainsKey(key))
            {
                OperationBase op = this._operations[key].Invoke();
                this._vm.AddOperation(op);
            }

            // Numeros 0-9
            // Operaciones + - * /
            // Enter =
            // Esc AC
        }

        // TODO - Bindear el resultado de la cuenta
        // TODO - programar el botón AC
        // TODO - capturar los input desde el teclado también
        // TODO - programar el botón +/-
        // TODO - programar el botón %
        // TODO - poder ingresar dígitos de mas de una cifra
    }
}