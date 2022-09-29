namespace DotISP.Parsec;

public abstract class Parsec<T, E>
{
    public abstract T Parse<Status, Tran, S>(S s) where S : IState<E, Status, Tran>;
}