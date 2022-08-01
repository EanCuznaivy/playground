using Orleans;
using Orleans.Hosting;
using Try.Orleans.GrainInterfaces;

var client = new ClientBuilder()
    .UseLocalhostClustering()
    .AddSimpleMessageStreamProvider("SMSProvider")
    .Build();
await using (client)
{
    await client.Connect();
    while (true)
    {
        Console.WriteLine("Enter a robot name.");
        var grainId = Console.ReadLine();
        var grain = client.GetGrain<IRobotGrain>(grainId);

        Console.WriteLine("Enter an instruction.");
        var instruction = Console.ReadLine();
        await grain.AddInstruction(instruction!);

        var count = await grain.GetInstructionCount();
        Console.WriteLine($"{grainId} has {count} instruction(s)");
    }
}
