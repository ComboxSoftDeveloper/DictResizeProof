namespace DictResizeProof.Diagnostics;

/// <summary>
/// Простые числа и число 101. Отчёт раздела 3: показывает, какие простые
/// числа пропускаются при выборе размера таблицы и какие размеры словарь
/// берёт при росте вместимости.
/// </summary>
internal static class Primes
{
    /// <summary>Число, на которое проверяется делимость при подборе размера.</summary>
    private const int HashPrime = 101;

    /// <summary>Выводит отброшенные простые и размеры, которые выбирает словарь.</summary>
    internal static int Run()
    {
        Console.WriteLine("Рантайм: " + Environment.Version);
        Console.WriteLine();
        Console.WriteLine("Простые числа, отброшенные при подборе размера таблицы:");
        Console.WriteLine("подходит только такое p, у которого (p - 1) не делится на " + HashPrime + ".");
        Console.WriteLine();

        int shown = 0;
        for (int i = 3; i < 200_000 && shown < 12; i += 2)
        {
            if (IsPrime(i) && (i - 1) % HashPrime == 0)
            {
                Console.WriteLine("  " + i.ToString().PadLeft(7) + "   (p - 1) / " + HashPrime + " = " + (i - 1) / HashPrime);
                shown++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Размеры, которые словарь берёт при росте вместимости:");
        Console.WriteLine();

        foreach (int wanted in new[] { 3, 10, 100, 1_000, 10_000, 100_000, 1_000_000 })
        {
            Console.WriteLine("  заказано " + wanted.ToString().PadLeft(8) + "   выбрано " + GetPrime(wanted));
        }

        return 0;
    }

    /// <summary>Подбор размера, повторяет HashHelpers.GetPrime для чисел вне таблицы.</summary>
    private static int GetPrime(int min)
    {
        for (int i = min | 1; i < int.MaxValue; i += 2)
        {
            if (IsPrime(i) && (i - 1) % HashPrime != 0)
            {
                return i;
            }
        }

        return min;
    }

    /// <summary>Проверка на простоту, повторяет HashHelpers.IsPrime.</summary>
    private static bool IsPrime(int candidate)
    {
        if ((candidate & 1) == 0)
        {
            return candidate == 2;
        }

        int limit = (int)Math.Sqrt(candidate);
        for (int divisor = 3; divisor <= limit; divisor += 2)
        {
            if (candidate % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }
}
