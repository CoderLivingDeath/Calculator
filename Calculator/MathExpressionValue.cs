using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class MathExpressionValue : MathExpressionItem
    {
        private protected object? _value { get; set; } = null;
    }

    public class MathExpressionDoubleValue : MathExpressionValue
    {
        public double Value => GetDoublveValue();

        public override Type ExpectedType => typeof(MathExpressionDoubleValue);

        public MathExpressionDoubleValue(double value)
        {
            _value = value;
        }

        private double GetDoublveValue()
        {
            if (_value == null) throw new Exception();
            if(_value !is double) throw new Exception();

            return (double)_value;
        }

        public override MathExpressionValue Calculate()
        {
            throw new NotImplementedException();
        }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
