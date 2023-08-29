using BenchmarkDotNet.Attributes;
using kyu.Kyu4;

[MemoryDiagnoser(true)]
[MarkdownExporter, HtmlExporter]
public class ParseIntReloaded_Benchmark
{
    [Params("one hundred forty four", "one million twenty two thousand fifteen")]
    public string? number;

    [Benchmark]
    public void ParseInt_Mine()
    {
        Kyu4.ParseInt_Mine(number!);
    }

    [Benchmark]
    public void ParseInt_MostPopular()
    {
        Kyu4.ParseInt_MostPopular(number!);
    }
}