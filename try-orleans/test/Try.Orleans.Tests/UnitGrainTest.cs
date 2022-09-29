using System.Threading.Tasks;
using Orleans.TestingHost;
using Try.Orleans.GrainInterfaces;

namespace Try.Orleans.Tests;

[Collection(ClusterCollection.Name)]
public class UnitGrainTest
{
    private readonly TestCluster _cluster;

    public UnitGrainTest(ClusterFixture fixture)
    {
        _cluster = fixture.Cluster;
    }

    [Fact]
    public async Task IsMessageCorrectAsync()
    {
        const string message = "Test";
        var grain = _cluster.GrainFactory.GetGrain<IUnitTestingGrain>(1);
        var result = await grain.ReturnMessageForTestAsync(message);
        var expected = $"message: {message}";
        Assert.Equal(expected, result);
    }
}