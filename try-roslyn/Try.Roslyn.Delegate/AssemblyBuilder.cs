namespace Try.Roslyn.Delegate;

public class AssemblyBuilder
{
    public string AssemblyName;

    public AssemblyBuilder(string? assemblyName = null)
    {
        AssemblyName = assemblyName ?? Guid.NewGuid().ToString("N");
    }
}