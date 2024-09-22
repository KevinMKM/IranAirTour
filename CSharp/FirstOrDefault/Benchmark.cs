using BenchmarkDotNet.Attributes;

namespace FirstOrDefault;


[MemoryDiagnoser(false)]
public class Benchmark
{
    private readonly List<int> _rowNumbers;

    public Benchmark()
    {
        _rowNumbers = Enumerable.Range(1, 1000).ToList();
    }

    [Benchmark]
    public int FindRow()
    {
        return _rowNumbers.Find(z => z == 500)!;
    }

    [Benchmark]
    public int FirstOrDefaultRow()
    {
        return _rowNumbers.FirstOrDefault(z => z == 500)!;
    }
    
    [Benchmark]
    public int SingleOrDefaultRow()
    {
        return _rowNumbers.SingleOrDefault(z => z == 500)!;
    }
    
}