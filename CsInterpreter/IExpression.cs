namespace CsInterpreter
{
    public interface IExpression
    {
        void Interpret(Context context);
    }
}