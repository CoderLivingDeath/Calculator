using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class MathExpressionItem
    {
        public MathExpressionItem[] Args { get; protected set; }

        public abstract Type ExpectedType { get; }

        protected MathExpressionItem(params MathExpressionItem[] args)
        {
            Args = args;
        }

        public abstract MathExpressionValue Calculate();

        public abstract bool Validate();
    }
}
