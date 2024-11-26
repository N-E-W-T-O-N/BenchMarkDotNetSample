using BenchmarkDotNet.Running;
using SampleClass;

var summary = BenchmarkRunner.Run<Md5VsSha256>();

// Test in Release