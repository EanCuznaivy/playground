using System.Net.Sockets;

namespace Try.Build.Redis.Core;

public partial class Redis
{
    public async Task HandleConnectionAsync(TcpClient tcpClient)
    {
        using var _ = tcpClient;
        await using var stream = tcpClient.GetStream();
        using var reader = new StreamReader(stream);
        await using var writer = new StreamWriter(stream)
        {
            NewLine = "\r\n",
            AutoFlush = true
        };

        try
        {
            var args = new List<string>();
            while (true)
            {
                args.Clear();
                var line = await reader.ReadLineAsync();
                if (line == null)
                {
                    break;
                }

                if (line[0] != '*')
                {
                    throw new InvalidDataException("Cannot understand arg batch: " + line);
                }

                if (!int.TryParse(line.AsSpan(1), out var argsv)) continue;

                for (var i = 0; i < argsv; i++)
                {
                    line = await reader.ReadLineAsync();
                    if (line == null || line[0] != '$')
                    {
                        throw new InvalidDataException("Cannot understand arg length: " + line);
                    }

                    if (int.TryParse(line.AsSpan(1), out var argLen))
                    {
                        line = await reader.ReadLineAsync();

                        if (line == null || line.Length != argLen)
                        {
                            throw new InvalidDataException("Wrong arg length expected " + argLen + " got: " + line);
                        }

                        args.Add(line);
                    }
                }

                var reply = ExecuteCommand(args);
                if (reply == null)
                {
                    await writer.WriteLineAsync("$-1");
                }
                else
                {
                    await writer.WriteLineAsync($"${reply.Length}\r\n{reply}");
                }
            }
        }
        catch (Exception e)
        {
            try
            {
                var errReader = new StringReader(e.ToString());
                while (await errReader.ReadLineAsync() is { } line)
                {
                    await writer.WriteAsync("-");
                    await writer.WriteLineAsync(line);
                }
            }
            catch
            {
                // ignored
            }
        }
    }
}