using Try.SmartContract.Types;

namespace Try.SmartContract.ContractB;

public class ContractB : IContract
{
    public string Name => "ContractB";

    public string Hello3()
    {
        Console.WriteLine("Hello3 from ContractB");
        return "Hello3";
    }

    public string Hello4()
    {
        Console.WriteLine("Hello4 from ContractB");
        return "Hello4";
    }
}