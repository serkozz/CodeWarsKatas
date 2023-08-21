using BenchmarkDotNet.Attributes;
using kyu.Kyu5;

[MemoryDiagnoser(true)]
[MarkdownExporter, HtmlExporter]
public class MoveZeroes_Benchmark
{
    [Params(10, 100, 1_000, 10_000, 100_000, 1_000_000)]
    public int N;

    private int[]? arr;

    [GlobalSetup]
    public void GlobalSetup()
    {
        arr = new int[N]; // executed once per each N value
    }

    [Benchmark]
    public void MoveZeros_Mine()
    {
        Kyu5.MoveZeroes_Mine(arr!);
    }

    [Benchmark]
    public void MoveZeros_MostPopular()
    {
        Kyu5.MoveZeroes_MostPopular(arr!);
    }
}