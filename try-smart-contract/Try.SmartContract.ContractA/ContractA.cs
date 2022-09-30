using Try.SmartContract.Types;

namespace Try.SmartContract.ContractA;

public class ContractA : IContract
{
    public string Name => "ContractA";

    public string Hello1()
    {
        Console.WriteLine("Hello1 from ContractA");
        return "Hello1";
    }

    public string Hello2()
    {
        Console.WriteLine("Hello2 from ContractA");
        return "Hello2";
    }
}