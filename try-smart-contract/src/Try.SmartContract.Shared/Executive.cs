using System.Reflection;
using Try.SmartContract.Types;

namespace Try.SmartContract.Shared;

public class Executive : IExecutive
{
    public DateTime LastUsedTime { get; set; }
    public Version ContractVersion { get; }

    private object? _contractInstance;

    public Executive()
    {
        
    }

    public Task<object?> ApplyAsync(string methodName, object?[]? parameters)
    {
        var methods = _contractInstance!.GetType().GetMethods();
        var method = methods.SingleOrDefault(m => m.Name == methodName);
        if (method == null)
        {
            throw new Exception();
        }

        return Task.FromResult(method.Invoke(_contractInstance, parameters));
    }

    public void SetAssembly(Assembly assembly)
    {
        _contractInstance = Activator.CreateInstance(assembly.GetTypes()
            .SingleOrDefault(t => typeof(IContract).IsAssignableFrom(t) && !t.IsNested)!);
    }
}