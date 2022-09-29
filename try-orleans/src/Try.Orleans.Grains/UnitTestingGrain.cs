using System.Threading.Tasks;
using Orleans;
using Try.Orleans.GrainInterfaces;

namespace Try.Orleans.Grains;

public class UnitTestingGrain : Grain, IUnitTestingGrain
{
    public Task<string> ReturnMessageForTestAsync(string message)
    {
        return Task.FromResult($"message: {message}");
    }
}