using System.Runtime.CompilerServices;
using DictResizeProof.Types;

namespace DictResizeProof;

/// <summary>
/// Все измеряемые методы. У каждого NoInlining: иначе компилятор встроит
/// метод в тело замера и удалит как ненужную работу.
/// </summary>
internal static class Subjects
{
    // ---------- Раздел 1: ключ номер 102 ----------

    /// <summary>
    /// Поиск всех ключей набора. Пока компаратор не заменён, поиск перебирает
    /// записи одного бакета. После замены записи распределены по бакетам.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int Lookup(Dictionary<string, int> map, string[] keys)
    {
        int found = 0;
        for (int i = 0; i < keys.Length; i++)
        {
            if (map.TryGetValue(keys[i], out _))
            {
                found++;
            }
        }

        return found;
    }

    /// <summary>Наполнение словаря заданным набором ключей.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Dictionary<string, int> Fill(string[] keys, IEqualityComparer<string>? comparer)
    {
        Dictionary<string, int> map = new(Payloads.Capacity, comparer);
        for (int i = 0; i < keys.Length; i++)
        {
            map[keys[i]] = i;
        }

        return map;
    }

    // ---------- Раздел 2: остаток двумя умножениями ----------

    /// <summary>Номер бакета через оператор процента.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static uint SumRemainder(uint[] data, uint divisor)
    {
        uint total = 0;
        for (int i = 0; i < data.Length; i++)
        {
            total += data[i] % divisor;
        }

        return total;
    }

    /// <summary>Тот же номер через два умножения и сдвиг.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static uint SumFastMod(uint[] data, uint divisor, ulong multiplier)
    {
        uint total = 0;
        for (int i = 0; i < data.Length; i++)
        {
            total += Payloads.FastMod(data[i], divisor, multiplier);
        }

        return total;
    }
}
