namespace Calculator.Operations
{
    public abstract class MathExpressionOperation : MathExpressionItem
    {
        protected MathExpressionOperation(params MathExpressionItem[] args) : base(args)
        {
        }
    }
}
