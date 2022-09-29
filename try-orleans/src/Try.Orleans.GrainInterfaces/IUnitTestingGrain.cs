using System.Threading.Tasks;
using Orleans;

namespace Try.Orleans.GrainInterfaces;

public interface IUnitTestingGrain : IGrainWithIntegerKey
{
    Task<string> ReturnMessageForTestAsync(string message);
}