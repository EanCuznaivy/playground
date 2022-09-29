namespace DotISP.Parsec;

public class Choice<TP, TR> : Parsec<TP, TR>
{
    private readonly IEnumerable<Parsec<TP, TR>> _parsecs;

    public Choice(IEnumerable<Parsec<TP, TR>> parsecs)
    {
        _parsecs = parsecs;
    }

    public override TP Parse<Status, Tran, S>(S s)
    {
        throw new NotImplementedException();
    }
}