using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Streams;
using Try.Orleans.GrainInterfaces;

namespace Try.Orleans.Grains;

public class RobotGrain : Grain, IRobotGrain
{
    private readonly ILogger<RobotGrain> _logger;
    private readonly Queue<string> _instructions = new();
    private IAsyncStream<InstructionMessage> _stream;

    public RobotGrain(ILogger<RobotGrain> logger)
    {
        _logger = logger;
    }

    public Task AddInstruction(string instruction)
    {
        _logger.LogWarning($"{this.GetPrimaryKeyString()} adding instruction {instruction}");
        _instructions.Enqueue(instruction);
        return Task.CompletedTask;
    }

    public async Task<string> GetNextInstruction()
    {
        if (_instructions.Count == 0)
        {
            return null;
        }

        var instruction = _instructions.Dequeue();
        _logger.LogWarning($"{this.GetPrimaryKeyString()} next instruction: {instruction}");
        await Publish(instruction);
        return instruction;
    }

    public Task<int> GetInstructionCount()
    {
        return Task.FromResult(_instructions.Count);
    }

    private Task Publish(string instruction)
    {
        var message = new InstructionMessage
        {
            Instruction = instruction,
            Robot = this.GetPrimaryKeyString()
        };
        return _stream.OnNextAsync(message);
    }
}