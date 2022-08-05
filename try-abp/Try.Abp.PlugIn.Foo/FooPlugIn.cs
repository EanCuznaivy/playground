using Try.Abp.PlugIn.Core;

namespace Try.Abp.Plugin.Foo;

public class FooPlugIn : IPlugIn
{
    public string Display()
    {
        return "foo";
    }
}