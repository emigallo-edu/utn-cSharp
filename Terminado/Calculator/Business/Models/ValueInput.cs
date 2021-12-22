using System;
using System.Collections.Generic;
using Business.Interfaces;
using Business.Operations;

namespace Business.Models
{
    public class ValueInput : ICopy
    {
        public ValueInput(double value)
        {
            this.Value = value;
            this.Operations = new List<OperationBase>();
        }

        public double Value { get; init; }

        public List<OperationBase> Operations { get; init; }
    }
}