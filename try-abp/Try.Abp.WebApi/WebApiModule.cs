using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Try.Abp.WebApi;

[DependsOn(
    typeof(AbpAutofacModule)
    )]
public class WebApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var services = context.Services;
        services.AddControllers();
    }
}