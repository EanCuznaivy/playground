namespace DotISP.Ast;

public interface IElement
{
    double Eval(Env env);
}