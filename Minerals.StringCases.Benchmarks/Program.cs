namespace Minerals.StringCases.Benchmarks
{
    public static class Program
    {
        public static void Main()
        {
            BenchmarkRunner.Run<StringExtensionsBenchmarks>
            (
                DefaultConfig.Instance
                    .AddJob(Job.Default.WithRuntime(CoreRuntime.Core80))
                    .AddValidator(JitOptimizationsValidator.FailOnError)
                    .AddDiagnoser(MemoryDiagnoser.Default)
            );
        }
    }
}