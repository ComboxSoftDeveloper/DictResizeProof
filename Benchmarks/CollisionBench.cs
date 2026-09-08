using BenchmarkDotNet.Attributes;
using DictResizeProof.Types;

namespace DictResizeProof.Benchmarks;

/// <summary>
/// Раздел 1. Поиск в словаре, все ключи которого дают один номер бакета.
/// Пока счётчик коллизий не превысил 100, поиск перебирает записи одного
/// бакета. При вставке 102-го ключа словарь заменяет компаратор и заново
/// вычисляет хеш-коды: записи распределяются по бакетам, и поиск снова
/// выполняется за O(1).
/// </summary>
public class CollisionBench
{
    private Dictionary<string, int> _map = [];
    private string[] _keys = [];

    /// <summary>Сколько ключей в одном бакете. Замена выполняется на 102-м.</summary>
    [ParamsSource(nameof(ChainValues))]
    public int Chain { get; set; }

    /// <summary>
    /// Набор ключей: same — все дают один номер бакета, spread — подбора нет.
    /// Второй набор нужен для сравнения: столько же ключей без подбора.
    /// </summary>
    [Params("same", "spread")]
    public string Keys { get; set; } = "same";

    /// <summary>Длины цепочек общие с отчётами.</summary>
    public static IEnumerable<int> ChainValues => Payloads.Chains;

    /// <summary>Подготовка вынесена сюда: в теле замера её быть не должно.</summary>
    [GlobalSetup]
    public void Setup()
    {
        Dictionary<string, int> probe = new(Payloads.Capacity);
        int buckets = Innards.Buckets(probe).Length;

        _keys = Keys == "same"
            ? Payloads.SameBucket(Chain, buckets)
            : Payloads.Spread(Chain);

        _map = Subjects.Fill(_keys, null);
    }

    /// <summary>Поиск всех ключей набора.</summary>
    [Benchmark]
    public int Lookup() => Subjects.Lookup(_map, _keys);
}
