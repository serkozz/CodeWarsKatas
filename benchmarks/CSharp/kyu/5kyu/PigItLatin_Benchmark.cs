using BenchmarkDotNet.Attributes;
using kyu.Kyu5;

[MemoryDiagnoser(true)]
[MarkdownExporter, HtmlExporter]
public class PigIt_Benchmark
{
    [Benchmark]
    public void PigIt_Mine()
    {
        Kyu5.PigIt_Mine("Pig latin is cool but if u think not u will die soon");
    }

    [Benchmark]
    public void PigIt_MostPopular()
    {
        Kyu5.PigIt_MostPopular("Pig latin is cool but if u think not u will die soon");
    }
}