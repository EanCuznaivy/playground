using Benchmark.StackAndHeap;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<StackAndHeapTests>();

/*
|                      Method |     Mean |    Error |   StdDev |
|---------------------------- |---------:|---------:|---------:|
|    ProcessClassNoReferences | 49.52 ns | 0.982 ns | 0.964 ns |
|   ProcessStructNoReferences | 43.59 ns | 0.292 ns | 0.273 ns |
|  ProcessClassWithReferences | 60.04 ns | 1.110 ns | 0.984 ns |
| ProcessStructWithReferences | 52.76 ns | 0.383 ns | 0.358 ns |
 */