using BenchmarkDotNet.Attributes;
using DictResizeProof.Types;

namespace DictResizeProof.Benchmarks;

/// <summary>
/// Раздел 2. Номер бакета — остаток от деления хеш-кода на длину массива
/// бакетов. Делитель не известен при компиляции, поэтому компилятор заменить
/// деление умножением не может. Словарь делает такую замену сам: два умножения
/// и сдвиг вместо деления.
/// </summary>
public class FastModBench
{
    private uint[] _data = [];

    private uint _divisor;
    private ulong _multiplier;

    /// <summary>Три размера.</summary>
    [ParamsSource(nameof(SizeValues))]
    public int Size { get; set; }

    /// <summary>Размеры общие с остальными замерами.</summary>
    public static IEnumerable<int> SizeValues => Payloads.Sizes;

    /// <summary>Подготовка: делитель берётся в рантайме, иначе JIT свернёт деление.</summary>
    [GlobalSetup]
    public void Setup()
    {
        _data = Payloads.Numbers(Size);

        _divisor = (uint)Innards.Buckets(new Dictionary<string, int>(Payloads.Capacity)).Length;
        _multiplier = Payloads.FastModMultiplier(_divisor);
    }

    /// <summary>Обычный остаток.</summary>
    [Benchmark(Baseline = true)]
    public uint Remainder() => Subjects.SumRemainder(_data, _divisor);

    /// <summary>Остаток двумя умножениями.</summary>
    [Benchmark]
    public uint FastMod() => Subjects.SumFastMod(_data, _divisor, _multiplier);
}
