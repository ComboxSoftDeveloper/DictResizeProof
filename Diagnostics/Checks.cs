using DictResizeProof.Types;

namespace DictResizeProof.Diagnostics;

/// <summary>
/// Сверка. Проверяет, что повтор внутренних вычислений словаря даёт тот же
/// результат, что и сам словарь, и что подобранные ключи получили один номер
/// бакета. Без этого замеры раздела 1 показывали бы не то, что заявлено.
/// </summary>
internal static class Checks
{
    /// <summary>Код возврата: 0 — всё сошлось, 1 — есть расхождение.</summary>
    internal static int Run()
    {
        bool ok = true;

        ok &= HashMatches();
        ok &= KeysCollide();

        ok &= NextEncoding();

        Console.WriteLine();
        Console.WriteLine(ok ? "СВЕРКА ПРОЙДЕНА" : "СВЕРКА НЕ ПРОЙДЕНА");

        return ok ? 0 : 1;
    }

    /// <summary>Повтор нерандомизированного хеша совпадает с хешем в записи словаря.</summary>
    private static bool HashMatches()
    {
        Console.WriteLine("Хеш строки: повтор против хеша в записи словаря");

        Dictionary<string, int> map = new(Payloads.Capacity);

        string[] keys = Payloads.Spread(8);
        for (int i = 0; i < keys.Length; i++)
        {
            map[keys[i]] = i;
        }

        Array entries = Innards.Entries(map);
        bool ok = true;

        for (int i = 0; i < keys.Length; i++)
        {
            uint stored = Innards.HashCode(entries, i);
            uint own = (uint)Payloads.NonRandomizedHash((string)Innards.Key(entries, i)!);

            ok &= Report("ключ " + Innards.Key(entries, i), stored == own, stored + " и " + own);
        }

        return ok;
    }

    /// <summary>Подобранные ключи лежат в одном бакете, пока порог не сработал.</summary>
    private static bool KeysCollide()
    {
        Console.WriteLine();
        Console.WriteLine("Подобранные ключи: все в одном бакете");

        Dictionary<string, int> probe = new(Payloads.Capacity);
        int buckets = Innards.Buckets(probe).Length;

        string[] keys = Payloads.SameBucket(101, buckets);
        Dictionary<string, int> map = Subjects.Fill(keys, null);

        int used = 0;
        foreach (int bucket in Innards.Buckets(map))
        {
            if (bucket != 0)
            {
                used++;
            }
        }

        return Report("занятых бакетов на 101 ключе", used == 1, used.ToString());
    }

    /// <summary>Живые записи держат next не меньше минус единицы, удалённые — меньше.</summary>
    private static bool NextEncoding()
    {
        Console.WriteLine();
        Console.WriteLine("Поле next: занятые записи и освободившиеся");

        Dictionary<string, int> map = new(Payloads.Capacity);

        string[] keys = Payloads.Spread(8);
        for (int i = 0; i < keys.Length; i++)
        {
            map[keys[i]] = i;
        }

        map.Remove(keys[3]);

        Array entries = Innards.Entries(map);

        bool live = true;
        for (int i = 0; i < keys.Length; i++)
        {
            if (i == 3)
            {
                continue;
            }

            live &= Innards.Next(entries, i) >= -1;
        }

        bool ok = Report("у занятых записей next не меньше -1", live, "");
        ok &= Report("после удаления ключа next меньше -1", Innards.Next(entries, 3) < -1, Innards.Next(entries, 3).ToString());

        return ok;
    }

    /// <summary>Одна строка отчёта.</summary>
    private static bool Report(string name, bool ok, string detail)
    {
        Console.WriteLine((ok ? "  ок   " : "  СБОЙ ") + name + (detail.Length == 0 ? "" : ": " + detail));
        return ok;
    }
}
