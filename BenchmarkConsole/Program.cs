// See https://aka.ms/new-console-template for more information
using BenchmarkConsole;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.InProcess.NoEmit;

Console.WriteLine("Starting Benchmark!");
var config = DefaultConfig.Instance.AddJob(Job.ShortRun.WithToolchain(InProcessNoEmitToolchain.Instance));
BenchmarkRunner.Run<P1_TwoSum_Benchmarks>(config);
