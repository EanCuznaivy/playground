using Shouldly;

namespace Try.HighPerformance.PredefinedDataTypes;

public class StaticTests
{
    [Fact]
    public void StaticTest()
    {
        StaticTestClass.StaticMethod();
        var obj = new StaticTestClass();
        obj.InstanceMethod();
        var result = obj.VirtualMethod();
        result.ShouldBe("child");
    }
}

public class StaticTestClass : StaticTestBaseClass
{
    public static void StaticMethod()
    {
    }

    public void InstanceMethod()
    {
    }

    public override string VirtualMethod()
    {
        return "child";
    }
}

public class StaticTestBaseClass
{
    public virtual string VirtualMethod()
    {
        return "parent";
    }
}