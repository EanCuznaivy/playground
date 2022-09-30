using Microsoft.Extensions.DependencyInjection;
using Orleans.Hosting;
using Orleans.TestingHost;
using Try.SmartContract.Contracts;
using Try.SmartContract.Grains;

namespace Try.SmartContract.Tests;

public class TestSiloConfigurations : ISiloConfigurator
{
    public void Configure(ISiloBuilder siloBuilder)
    {
        siloBuilder.ConfigureServices(services =>
        {
            services.AddSingleton<ISmartContractGrain, SmartContractGrain>();
        });
        siloBuilder.AddMemoryGrainStorageAsDefault();
        siloBuilder.AddMemoryGrainStorage("Executive");
    }
}