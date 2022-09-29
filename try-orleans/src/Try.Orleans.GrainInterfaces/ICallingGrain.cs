using System.Threading.Tasks;
using Orleans;

namespace Try.Orleans.GrainInterfaces;

public interface ICallingGrain : IGrainWithGuidKey
{
    Task<int> IncrementAsync(int number);
    Task<string> ReturnStringMessageAsync(int number);
}