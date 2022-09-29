using System.Net;
using System.Net.Sockets;
using Try.Build.Redis.Core;

var listener = new TcpListener(IPAddress.Any, RedisConstants.DefaultPortNumber);
listener.Start();

var redis = new Redis();

while (true)
{
    var client = await listener.AcceptTcpClientAsync();
    var _ = redis.HandleConnectionAsync(client);
}