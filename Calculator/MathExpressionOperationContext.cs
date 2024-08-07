using Calculator.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class MathExpressionOperationContext
    {
        protected MathExpressionItem[] Args { get; }

        public MathExpressionOperationContext(params MathExpressionItem[] args)
        {
            Args = args;
        }
    }
}
