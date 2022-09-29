namespace DotISP.Ast;

public class Add : ILambda
{
    public double Apply(IEnumerable<object> args)
    {
        return args.Cast<double>().Sum();
    }
}

public class Sub : ILambda
{
    public double Apply(IEnumerable<object> args)
    {
        var argList = args.ToList();
        var result = (double)argList.First();
        return argList.Skip(1).Aggregate(result, (current, item) => current - (double)item);
    }
}

public class Product : ILambda
{
    public double Apply(IEnumerable<object> args)
    {
        return args.Aggregate(1.0, (current, item) => current * (double)item);
    }
}

public class Divide : ILambda
{
    public double Apply(IEnumerable<object> args)
    {
        var argList = args.ToList();
        var result = (double)argList.First();
        return argList.Cast<double>().Aggregate(result, (current, item) => current / item);
    }
}