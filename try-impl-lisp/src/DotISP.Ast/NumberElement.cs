namespace DotISP.Ast;

public class NumberElement : IElement
{
    private readonly double _value;

    public NumberElement(double value)
    {
        _value = value;
    }

    public double Eval(Env env)
    {
        return _value;
    }
}