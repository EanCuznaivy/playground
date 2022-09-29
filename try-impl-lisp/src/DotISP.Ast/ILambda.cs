namespace DotISP.Ast;

public interface ILambda
{
    double Apply(IEnumerable<object> args);
}