using BenchmarkDotNet.Attributes;
using Solutions;

namespace BenchmarkConsole;

public sealed class P1_TwoSum_Benchmarks
{
    [Params(10, 100, 1_000, 100_000)]
    public int N;

    [GlobalSetup]
    public void Setup()
    {
        var random = new Random(42);
        nums = new int[N];
        for (int i = 0; i < N; i++)
        {
            nums[i] = random.Next(1, N);
        }

        target = nums[random.Next(0, N - 1)] + nums[random.Next(0, N - 1)];
    }

    private int[] nums;
    private int target;

    [Benchmark]
    public int[] FirstAttemptBenchmark() => P1_TwoSum_Solutions.FirstAttempt(nums, target);

    [Benchmark]
    public int[] SecondAttemptBenchmark() => P1_TwoSum_Solutions.SecondAttempt(nums, target);
}
