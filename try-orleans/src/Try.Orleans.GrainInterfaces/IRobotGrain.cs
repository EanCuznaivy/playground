using System.Threading.Tasks;
using Orleans;

namespace Try.Orleans.GrainInterfaces;

public interface IRobotGrain : IGrainWithStringKey
{
    Task AddInstruction(string instruction);
    Task<string> GetNextInstruction();
    Task<int> GetInstructionCount();
}