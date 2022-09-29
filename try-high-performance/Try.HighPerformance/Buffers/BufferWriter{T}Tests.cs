using System.Buffers;

namespace Try.HighPerformance.Buffers;

public class BufferWriterTests
{
    [Fact]
    public void BufferWriterTest()
    {
        var bufferWriter = new ArrayBufferWriter<int>();
    }
}