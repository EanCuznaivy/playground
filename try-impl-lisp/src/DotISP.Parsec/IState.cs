namespace DotISP.Parsec;

public interface IState
{
    
}

/// <summary>
/// 
/// </summary>
/// <typeparam name="TE">Element</typeparam>
/// <typeparam name="TS">Status</typeparam>
/// <typeparam name="TT">Transaction</typeparam>
public interface IState<TE, TS, TT> : IState
{
    TE Next();

    TS Status();

    TT Begin();

    TT Begin(TT transaction);

    void Commit(TT transaction);

    void Rollback(TT transaction);

    ParsecException Trap(string message);
}