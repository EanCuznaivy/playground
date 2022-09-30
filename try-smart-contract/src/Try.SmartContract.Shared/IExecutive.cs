using System.Reflection;

namespace Try.SmartContract.Shared;

public interface IExecutive
{
    DateTime LastUsedTime { get; set; }
    Version ContractVersion { get; }
    Task<object?> ApplyAsync(string methodName, object?[]? parameters);
    void SetAssembly(Assembly assembly);
}