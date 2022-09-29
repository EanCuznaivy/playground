using IronPython.Hosting;
using Xunit.Abstractions;

namespace Try.IronPython.Test;

public class UnitTest1
{
    private readonly ITestOutputHelper _testOutputHelper;

    public UnitTest1(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Test1()
    {
        var eng = Python.CreateEngine();
        var scope = eng.CreateScope();
        eng.Execute(@"
def greetings(name):
    return 'Hello ' + name.title() + '!'
", scope);
        var greetings = scope.GetVariable("greetings");
        _testOutputHelper.WriteLine(greetings("world"));
    }
}