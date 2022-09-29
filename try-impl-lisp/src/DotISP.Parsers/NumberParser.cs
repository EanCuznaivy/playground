using DotISP.Parsec;

namespace DotISP.Parsers;

public class NumberParser : Parsec<double, char>
{
    public override double Parse<Status, Tran, S>(S s)
    {
        
        return double.Parse(decimal.Parse(s))
    }
}