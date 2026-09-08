using System.Numerics;

namespace DictResizeProof.Types;

/// <summary>
/// Наборы ключей и повтор тех вычислений, которые словарь делает внутри себя.
/// Повтор нужен, чтобы подобрать ключи, попадающие в один бакет. Правильность
/// повтора проверяет сверка: она сравнивает посчитанный здесь хеш с тем, что
/// словарь положил в свою запись.
/// </summary>
internal static class Payloads
{
    /// <summary>
    /// Число ключей в одном бакете, на котором снимаются замеры раздела 1.
    /// Замена компаратора выполняется при вставке 102-го ключа: счётчик
    /// коллизий учитывает записи, уже занимающие бакет, поэтому условие
    /// «больше 100» выполняется, когда их 101.
    /// </summary>
    internal static readonly int[] Chains = [50, 101, 102, 200];

    /// <summary>Три размера для замеров раздела 2.</summary>
    internal static readonly int[] Sizes = [10_000, 100_000, 1_000_000];

    /// <summary>Вместимость словаря в замерах раздела 1. Взята с запасом, чтобы
    /// массив бакетов за время замера ни разу не увеличивался.</summary>
    internal const int Capacity = 1024;

    /// <summary>
    /// Нерандомизированный хеш строки, повторяет String.GetNonRandomizedHashCode.
    /// Именно его словарь применяет к строковым ключам, пока не сработал порог
    /// коллизий.
    /// </summary>
    internal static int NonRandomizedHash(string value)
    {
        uint hash1 = (5381u << 16) + 5381u;
        uint hash2 = hash1;

        int length = value.Length;
        int i = 0;

        while (length > 2)
        {
            length -= 4;

            hash1 = (BitOperations.RotateLeft(hash1, 5) + hash1) ^ Pair(value, i);
            hash2 = (BitOperations.RotateLeft(hash2, 5) + hash2) ^ Pair(value, i + 2);
            
            i += 4;
        }

        if (length > 0)
        {
            hash2 = (BitOperations.RotateLeft(hash2, 5) + hash2) ^ Pair(value, i);
        }

        return (int)(hash1 + hash2 * 1566083941);
    }

    /// <summary>
    /// Пара символов как одно 32-битное слово. За концом строки лежит
    /// завершающий ноль: рантайм читает его наравне с остальными символами.
    /// </summary>
    private static uint Pair(string value, int index)
    {
        uint low = index < value.Length ? value[index] : 0u;
        uint high = index + 1 < value.Length ? value[index + 1] : 0u;

        return low | (high << 16);
    }

    /// <summary>Множитель для быстрого остатка, повторяет HashHelpers.GetFastModMultiplier.</summary>
    internal static ulong FastModMultiplier(uint divisor) => ulong.MaxValue / divisor + 1;

    /// <summary>
    /// Остаток от деления двумя умножениями, повторяет HashHelpers.FastMod.
    /// Словарь считает так номер бакета на 64-битных платформах.
    /// </summary>
    internal static uint FastMod(uint value, uint divisor, ulong multiplier)
        => (uint)(((((multiplier * value) >> 32) + 1) * divisor) >> 32);

    /// <summary>
    /// Ключи, дающие один номер бакета при таблице заданной длины. Столько,
    /// сколько заказано: на 102-м словарь заменит компаратор, и остальные
    /// распределятся по бакетам, но в подборе они уже учтены.
    /// </summary>
    internal static string[] SameBucket(int count, int buckets)
    {
        ulong multiplier = FastModMultiplier((uint)buckets);
        string[] result = new string[count];

        int found = 0;
        for (int i = 0; found < count; i++)
        {
            string candidate = "k" + i.ToString(System.Globalization.CultureInfo.InvariantCulture);
            uint hash = (uint)NonRandomizedHash(candidate);

            if (FastMod(hash, (uint)buckets, multiplier) == 0)
            {
                result[found] = candidate;
                found++;
            }
        }

        return result;
    }

    /// <summary>Ключи без подбора: расходятся по бакетам как придётся.</summary>
    internal static string[] Spread(int count)
    {
        string[] result = new string[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = "key" + i.ToString(System.Globalization.CultureInfo.InvariantCulture);
        }

        return result;
    }

    /// <summary>Числа для замеров быстрого остатка.</summary>
    internal static uint[] Numbers(int count)
    {
        uint[] result = new uint[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = (uint)(i * 2654435761u);
        }

        return result;
    }
}
