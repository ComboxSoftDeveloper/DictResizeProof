using DictResizeProof.Types;

namespace DictResizeProof.Diagnostics;

/// <summary>
/// Отрицательные значения в поле next и нумерация бакетов с единицы.
/// Отчёт к разделу «Что ещё есть в исходниках»: выводит содержимое бакетов
/// и поле next у занятых записей и у тех, что остались после удаления ключа.
/// </summary>
internal static class Entries
{
    /// <summary>Выводит содержимое бакетов и записей маленького словаря.</summary>
    internal static int Run()
    {
        Console.WriteLine("Рантайм: " + Environment.Version);
        Console.WriteLine();

        Dictionary<string, int> map = new(4);

        string[] keys = Payloads.Spread(6);
        for (int i = 0; i < keys.Length; i++)
        {
            map[keys[i]] = i;
        }

        Dump("после шести вставок", map);

        map.Remove(keys[1]);
        map.Remove(keys[4]);

        Dump("после удаления двух ключей", map);

        Console.WriteLine("Значение 0 в бакете означает «пусто»: номер записи хранится");
        Console.WriteLine("увеличенным на единицу, поэтому обнулённая память годится как есть.");
        Console.WriteLine("У живой записи next не меньше -1, у удалённой — меньше.");

        return 0;
    }

    /// <summary>Печать бакетов и записей.</summary>
    private static void Dump(string title, Dictionary<string, int> map)
    {
        int[] buckets = Innards.Buckets(map);
        Array entries = Innards.Entries(map);
        
        Console.WriteLine(title);
        Console.Write("  бакеты:");

        foreach (int bucket in buckets)
        {
            Console.Write(" " + bucket);
        }

        Console.WriteLine();

        for (int i = 0; i < Innards.Count(map); i++)
        {
            object? key = Innards.Key(entries, i);
            int next = Innards.Next(entries, i);

            string state = next >= -1 ? "живая" : "удалённая";
            Console.WriteLine("  запись " + i + "  next " + next.ToString().PadLeft(3) + "  " + state.PadRight(10) + "ключ " + (key ?? "нет"));
        }

        Console.WriteLine();
    }
}
