using Benchmark.Dynamic;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<DynamicTests>();

/*
|                  Method |      Mean |     Error |    StdDev |    Median |
|------------------------ |----------:|----------:|----------:|----------:|
|         MeasureVarUsage | 0.0009 ns | 0.0021 ns | 0.0018 ns | 0.0000 ns |
|  MeasureVarDynamicUsage | 0.0000 ns | 0.0002 ns | 0.0001 ns | 0.0000 ns |
| MeasureTypeDynamicUsage | 4.5149 ns | 0.0622 ns | 0.0582 ns | 4.4914 ns |
|    MeasureTypeTypeUsage | 0.0003 ns | 0.0012 ns | 0.0010 ns | 0.0000 ns |
 */