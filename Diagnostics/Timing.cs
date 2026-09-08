using System.Diagnostics;
using DictResizeProof.Types;

namespace DictResizeProof.Diagnostics;

/// <summary>
/// Те же замеры на секундомере из отдельного процесса. Показывает, что выводы
/// не зависят от инструмента: три прохода, печатается разброс.
/// </summary>
internal static class Timing
{
    /// <summary>Сколько проходов на вариант.</summary>
    private const int Passes = 3;

    /// <summary>Выводит время по каждому варианту.</summary>
    internal static int Run()
    {
        Console.WriteLine("Рантайм: " + Environment.Version);
        Console.WriteLine("Проходов: " + Passes);
        Console.WriteLine();

        Dictionary<string, int> probe = new(Payloads.Capacity);
        int buckets = Innards.Buckets(probe).Length;

        foreach (int chain in Payloads.Chains)
        {
            string[] keys = Payloads.SameBucket(chain, buckets);
            Dictionary<string, int> map = Subjects.Fill(keys, null);

            Row("ключей в бакете " + chain, () => Subjects.Lookup(map, keys));
        }

        Console.WriteLine();

        uint divisor = (uint)buckets;

        ulong multiplier = Payloads.FastModMultiplier(divisor);
        uint[] data = Payloads.Numbers(Payloads.Sizes[^1]);

        Row("остаток", () => (int)Subjects.SumRemainder(data, divisor));
        Row("два умножения", () => (int)Subjects.SumFastMod(data, divisor, multiplier));


        return 0;
    }

    /// <summary>Один вариант: прогрев, три прохода, разброс.</summary>
    private static void Row(string name, Func<int> body)
    {
        for (int i = 0; i < 5; i++)
        {
            _ = body();
        }

        double[] times = new double[Passes];
        Stopwatch watch = new();

        for (int pass = 0; pass < Passes; pass++)
        {
            watch.Restart();
            
            int result = body();
            watch.Stop();

            times[pass] = watch.Elapsed.TotalMilliseconds;

            if (result == int.MinValue)
            {
                Console.WriteLine("недостижимо");
            }
        }

        double min = times[0];
        double max = times[0];

        double sum = 0;
        foreach (double value in times)
        {
            if (value < min)
            {
                min = value;
            }

            if (value > max)
            {
                max = value;
            }

            sum += value;
        }

        double mean = sum / Passes;
        double spread = mean == 0 ? 0 : (max - min) / mean * 100;

        Console.WriteLine("  " + name.PadRight(26)
            + "среднее " + mean.ToString("F4", System.Globalization.CultureInfo.InvariantCulture) + " мс"
            + ", разброс " + spread.ToString("F1", System.Globalization.CultureInfo.InvariantCulture) + " %");
    }
}
