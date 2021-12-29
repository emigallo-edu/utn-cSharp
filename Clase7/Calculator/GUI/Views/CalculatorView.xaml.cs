using Business.Operations;
using GUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GUI.Views
{
    public partial class CalculatorView : Window
    {
        private CalculatorViewModel _vm;
        private Dictionary<string, OperationBase> _operations;

        public CalculatorView()
        {
            InitializeComponent();
            this._vm = new CalculatorViewModel();
            DataContext = this._vm;

            this._operations = new Dictionary<string, OperationBase>();
            this._operations.Add("+", new AddOperation());
            this._operations.Add("-", new SubtractOperation());
            this._operations.Add("X", new MultiplyOperation());
            this._operations.Add("/", new DivideOperation());
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            double result = this._vm.CalculateResult();
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            int value = int.Parse(button.Content.ToString());
            this._vm.AddValue(value);
           // 8
           //2
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string key = button.Content.ToString();

            OperationBase op = this._operations[key];
            this._vm.AddOperation(op);
            //+
        }
    }
}