using System;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Hosting;
using Orleans.Statistics;
using Try.Orleans.Grains;
using Try.Orleans.GrainInterfaces;

var host = new SiloHostBuilder()
    .ConfigureApplicationParts(parts => parts.AddApplicationPart(typeof(RobotGrain).Assembly).WithReferences())
    .ConfigureApplicationParts(parts => parts.AddApplicationPart(typeof(UnitTestingGrain).Assembly).WithReferences())
    .ConfigureApplicationParts(parts => parts.AddApplicationPart(typeof(CallingGrain).Assembly).WithReferences())
    .UseLocalhostClustering()
    .ConfigureLogging(logging =>
    {
        logging.AddConsole();
        logging.SetMinimumLevel(LogLevel.Warning);
    })
    .UseDashboard()
    .UseLinuxEnvironmentStatistics()
    .AddMemoryGrainStorage("PubSubStore")
    .AddSimpleMessageStreamProvider("SMSProvider")
    .UseInMemoryReminderService()
    .Build();

await host.StartAsync();

var client = new ClientBuilder()
    .UseLocalhostClustering().Build();
await using (client)
{
    await client.Connect();
    var grain = client.GetGrain<IRobotGrain>("eanz");
    await grain.AddInstruction("eat");
}

Console.WriteLine("Press a key to stop the Silo.");
Console.ReadLine();

await host.StopAsync();