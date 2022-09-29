using System.Threading.Tasks;
using Orleans;
using Try.Orleans.GrainInterfaces;

namespace Try.Orleans.Grains;

public class CallingGrain : Grain, ICallingGrain
{
    private int _latest;

    public Task<int> IncrementAsync(int number)
    {
        _latest = number + 1;
        return Task.FromResult(_latest);
    }

    public Task<string> ReturnStringMessageAsync(int number)
    {
        var grain = GrainFactory.GetGrain<IUnitTestingGrain>(1);
        return grain.ReturnMessageForTestAsync(IncrementAsync(number).Result.ToString());
    }
}