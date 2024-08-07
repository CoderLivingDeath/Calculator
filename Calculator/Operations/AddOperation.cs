
namespace Calculator.Operations
{
    public class AddOperation : MathExpressionOperation
    {
        public MathExpressionItem Left { get; }
        public MathExpressionItem Right { get; }

        public override Type ExpectedType => typeof(MathExpressionDoubleValue);

        public AddOperation(MathExpressionItem left, MathExpressionItem right) : base(left, right)
        {
            Left = left;
            Right = right;
        }

        public override MathExpressionValue Calculate()
        {
            // древовидное вычесление по двум стронам
            var left = (MathExpressionDoubleValue)Left.Calculate(); 
            var right = (MathExpressionDoubleValue)Right.Calculate();

            return left.Value + right.Value; // TODO: мердж двух результатов вычесления
        }

        public override bool Validate()
        {
            if (Left.ExpectedType == typeof(MathExpressionDoubleValue) && Right.ExpectedType == typeof(MathExpressionDoubleValue))
            {
                return true;    
            }

            return false;
        }
    }
}
