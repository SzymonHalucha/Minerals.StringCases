using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Validators;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Jobs;

namespace Minerals.StringCases.Benchmarks
{
    public static class Program
    {
        public static void Main()
        {
            // BenchmarkRunner.Run<StringExtensionsComparison>
            BenchmarkRunner.Run<StringExtensionsBenchmarks>
            (
                DefaultConfig.Instance
                    .WithOrderer(new DefaultOrderer(SummaryOrderPolicy.FastestToSlowest))
                    .AddJob(Job.Default.WithRuntime(CoreRuntime.Core80))
                    .AddJob(Job.Default.WithRuntime(CoreRuntime.Core90))
                    .AddValidator(JitOptimizationsValidator.FailOnError)
                    .AddDiagnoser(MemoryDiagnoser.Default)
            );
        }
    }
}