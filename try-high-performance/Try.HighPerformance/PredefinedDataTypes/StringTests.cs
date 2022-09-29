using Shouldly;

namespace Try.HighPerformance.PredefinedDataTypes;

public class StringTests
{
    [Fact(DisplayName = "Strings are immutable")]
    public void StringTest()
    {
        var greeting1 = "Hello, world!";
        var greeting2 = greeting1;
        greeting1.ShouldBe(greeting2);
        greeting1 += " Isn't life grand!";
        greeting1.ShouldNotBe(greeting2);
    }
}