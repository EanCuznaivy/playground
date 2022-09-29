using System.Runtime.Loader;
using Shouldly;

namespace Try.HighPerformance.PredefinedDataTypes;

public class AssemblyLoadContextTests
{
    [Fact]
    public void AssemblyLoadContextTest()
    {
        var assemblies = AssemblyLoadContext.Default.Assemblies;
        assemblies.Count().ShouldBePositive();
    }
}