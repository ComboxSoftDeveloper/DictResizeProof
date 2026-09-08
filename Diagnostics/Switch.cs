using DictResizeProof.Types;

namespace DictResizeProof.Diagnostics;

/// <summary>
/// Замена компаратора. Главный отчёт раздела 1: показывает, при вставке
/// какого по счёту ключа словарь меняет компаратор, и что с посторонним
/// компаратором замена не выполняется ни при каком числе коллизий.
/// </summary>
internal static class Switch
{
    /// <summary>Выводит имя компаратора после каждой вставки.</summary>
    internal static int Run()
    {
        Console.WriteLine("Рантайм: " + Environment.Version);
        Console.WriteLine();

        Dictionary<string, int> probe = new(Payloads.Capacity);
        int buckets = Innards.Buckets(probe).Length;

        Console.WriteLine("Бакетов в словаре с заказанной вместимостью " + Payloads.Capacity + ": " + buckets);
        Console.WriteLine();

        Trace("компаратор не задан", null, buckets);

        Trace("StringComparer.Ordinal", StringComparer.Ordinal, buckets);
        Trace("свой компаратор", new OwnComparer(), buckets);

        return 0;
    }

    /// <summary>Наполнение с печатью имени компаратора на переломных вставках.</summary>
    private static void Trace(string title, IEqualityComparer<string>? comparer, int buckets)
    {
        string[] keys = Payloads.SameBucket(Payloads.Chains[^1], buckets);
        Dictionary<string, int> map = new(Payloads.Capacity, comparer);

        Console.WriteLine(title);
        Console.WriteLine("  до вставок           " + Innards.ComparerName(map));

        string? changedAt = null;
        string before = Innards.ComparerName(map);

        for (int i = 0; i < keys.Length; i++)
        {
            map[keys[i]] = i;

            string now = Innards.ComparerName(map);
            if (changedAt is null && now != before)
            {
                changedAt = (i + 1).ToString(System.Globalization.CultureInfo.InvariantCulture);
            }

            before = now;

            if (i + 1 is 101 or 102)
            {
                Console.WriteLine("  после " + (i + 1) + " вставок    " + now);
            }
        }

        Console.WriteLine("  замена на вставке    " + (changedAt ?? "не выполнена"));

        int used = 0;
        foreach (int bucket in Innards.Buckets(map))
        {
            if (bucket != 0)
            {
                used++;
            }
        }

        Console.WriteLine("  занятых бакетов      " + used + " из " + Innards.Buckets(map).Length);
        Console.WriteLine();
    }

    /// <summary>
    /// Свой компаратор строк. Считает так же, как стандартный, но словарь
    /// его не оборачивает и защиту не включает.
    /// </summary>
    private sealed class OwnComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y) => string.Equals(x, y, StringComparison.Ordinal);

        public int GetHashCode(string obj) => Payloads.NonRandomizedHash(obj);
    }
}
