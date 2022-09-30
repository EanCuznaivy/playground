using Orleans;
using Try.SmartContract.Shared;

namespace Try.SmartContract.Contracts;

public interface ISmartContractGrain : IGrainWithStringKey
{
    Task SetExecutiveAsync(Executive executive);
    Task<object?> ExecuteAsync(string methodName, object?[]? parameters);
    Task<Version> GetCurrentVersion();
}