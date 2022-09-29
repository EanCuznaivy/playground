using Microsoft.Extensions.DependencyInjection;
using Orleans.Hosting;
using Orleans.TestingHost;
using Try.Orleans.GrainInterfaces;
using Try.Orleans.Grains;

namespace Try.Orleans.Tests;

public class TestSiloConfigurations : ISiloBuilderConfigurator
{
    public void Configure(ISiloHostBuilder hostBuilder)
    {
        hostBuilder.ConfigureServices(services =>
        {
            // Services that need to talk to grains can be placed here
            services.AddSingleton<IUnitTestingGrain, UnitTestingGrain>();
        });
    }
}