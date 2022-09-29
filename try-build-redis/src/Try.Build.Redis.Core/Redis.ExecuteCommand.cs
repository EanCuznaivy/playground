using System.Collections.Concurrent;

namespace Try.Build.Redis.Core;

public partial class Redis
{
    private readonly ConcurrentDictionary<string, string> _state = new();

    private string? ExecuteCommand(List<string> args)
    {
        switch (args[0])
        {
            case "GET":
                return _state.GetValueOrDefault(args[1]);
            case "SET":
                _state[args[1]] = args[2];
                return null;
            default:
                throw new ArgumentOutOfRangeException("Unknown command: " + args[0]);
        }
    }
}