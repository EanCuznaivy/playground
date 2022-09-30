using System.Reflection;
using Orleans.TestingHost;
using Try.SmartContract.Contracts;
using Try.SmartContract.Shared;

namespace Try.SmartContract.Tests;

[Collection(ClusterCollection.Name)]
public class UnitGrainTest
{
    private readonly TestCluster _cluster;

    public UnitGrainTest(ClusterFixture fixture)
    {
        _cluster = fixture.Cluster;
    }

    [Fact]
    public async Task SmartContractGrainTest()
    {
        const string address = "0x01";
        var grain = _cluster.GrainFactory.GetGrain<ISmartContractGrain>(address);
    }

    [Fact]
    public async Task ExecutiveTest()
    {
        var contractCode = await File.ReadAllBytesAsync(typeof(ContractA.ContractA).Assembly.Location);
        var assembly = Assembly.Load(contractCode);
        var executive = new Executive();
        executive.SetAssembly(assembly);

        {
            var grain = _cluster.GrainFactory.GetGrain<ISmartContractGrain>("ContractA");
            await grain.SetExecutiveAsync(executive);
            var result = await grain.ExecuteAsync("Hello1", Array.Empty<object>());
            Assert.Equal("Hello1", (string)result!);
        }

        {
            var grain = _cluster.GrainFactory.GetGrain<ISmartContractGrain>("ContractA");
            var result = await grain.ExecuteAsync("Hello2", Array.Empty<object>());
            Assert.Equal("Hello2", (string)result!);
        }
    }
}