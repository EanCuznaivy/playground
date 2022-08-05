using Try.Abp.PlugIn.Core;

namespace Try.Abp.Plugin.Bar;

public class BarPlugIn : IPlugIn
{
    public string Display()
    {
        return "bar";
    }
}