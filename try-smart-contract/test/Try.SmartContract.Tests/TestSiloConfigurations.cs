using Microsoft.Extensions.DependencyInjection;
using Orleans.Hosting;
using Orleans.TestingHost;
using Try.SmartContract.Contracts;
using Try.SmartContract.Grains;

namespace Try.SmartContract.Tests;

public class TestSiloConfigurations : ISiloBuilderConfigurator
{
    public void Configure(ISiloHostBuilder hostBuilder)
    {
        hostBuilder.ConfigureServices(services =>
        {
            // Services that need to talk to grains can be placed here
            services.AddSingleton<ISmartContractGrain, SmartContractGrain>();
            services.AddFaultInjectionMemoryStorage("Executive");
        });
    }
}