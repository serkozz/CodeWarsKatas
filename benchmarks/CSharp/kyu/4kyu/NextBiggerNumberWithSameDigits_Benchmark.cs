using BenchmarkDotNet.Attributes;
using kyu.Kyu4;

[MemoryDiagnoser(true)]
[MarkdownExporter, HtmlExporter]
public class NextBiggerNumberWithSameDigits_Benchmark
{
    [Params(59884848459853, long.MaxValue)]
    public long number;

    [Benchmark]
    public void NextBiggerNumber_Mine_Site12sTimeoutIssueAppears()
    {
        Kyu4.NextBiggerNumber(number);
    }
}