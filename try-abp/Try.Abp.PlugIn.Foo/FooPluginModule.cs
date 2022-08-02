using Microsoft.Extensions.DependencyInjection;
using Try.Abp.PlugIn.Core;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Try.Abp.Plugin.Foo;

[DependsOn(
    typeof(AbpAutofacModule)
)]
public class FooPluginModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var services = context.Services;
        services.AddTransient<IPlugIn, FooPlugIn>();
    }
}