using Calculator.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MathExpression : MathExpressionItem
    {
        public Queue<MathExpressionItem> Operations { get; private set; }

        public override Type ExpectedType => throw new NotImplementedException();

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
