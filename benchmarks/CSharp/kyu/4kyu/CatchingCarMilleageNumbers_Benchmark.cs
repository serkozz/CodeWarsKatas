using BenchmarkDotNet.Attributes;
using kyu.Kyu4;

[MemoryDiagnoser(true)]
[MarkdownExporter, HtmlExporter]
public class CatchingCarMilleageNumbers_Benchmark
{
    [Params(1337, 1336, 11208)]
    public int number;

    public List<int>? awesomeNumbers;

    [GlobalSetup]
    public void GlobalSetup()
    {
        awesomeNumbers = new List<int>() { 1337, 256 };
    }

    [Benchmark]
    public void IsInteresting_Mine()
    {
        Kyu4.IsInteresting_Mine(number, awesomeNumbers!);
    }

    [Benchmark]
    public void IsInteresting_MostPopular()
    {
        Kyu4.IsInteresting_MostPopular(number, awesomeNumbers!);
    }
}