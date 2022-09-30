using Orleans;
using Orleans.Runtime;
using Try.SmartContract.Contracts;
using Try.SmartContract.Shared;

namespace Try.SmartContract.Grains;

public class SmartContractGrain : Grain, ISmartContractGrain
{
    private readonly IPersistentState<Executive> _executiveState;

    public SmartContractGrain([PersistentState("executive", "Executive")] IPersistentState<Executive> executiveState)
    {
        _executiveState = executiveState;
    }

    public Task SetExecutiveAsync(Executive executive)
    {
        _executiveState.State = executive;
        return Task.CompletedTask;
    }

    public async Task<object?> ExecuteAsync(string methodName, object?[]? parameters)
    {
        return await _executiveState.State.ApplyAsync(methodName, parameters);
    }

    public Task<Version> GetCurrentVersion()
    {
        return Task.FromResult(_executiveState.State.ContractVersion);
    }
}