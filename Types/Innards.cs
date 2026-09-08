using System.Reflection;

namespace DictResizeProof.Types;

/// <summary>
/// Чтение внутренних полей словаря. Всё, что проверяется в разделах 1 и 2,
/// лежит в приватных полях, публичного способа их увидеть нет.
///
/// Имена полей заданы строками, поэтому смена реализации сломает чтение.
/// Каждый метод при неудаче бросает исключение с именем поля: молча вернуть
/// неверное число хуже, чем остановиться.
/// </summary>
internal static class Innards
{
    private const BindingFlags Flags = BindingFlags.Instance | BindingFlags.NonPublic;

    /// <summary>Компаратор, которым словарь пользуется прямо сейчас.</summary>
    internal static object? Comparer<TKey, TValue>(Dictionary<TKey, TValue> map) where TKey : notnull
        => Field(map, "_comparer").GetValue(map);

    /// <summary>
    /// Имя типа компаратора вместе с внешним типом. Короткого имени мало:
    /// у нерандомизированного и рандомизированного компараторов вложенные типы
    /// называются одинаково, различается только внешний.
    /// </summary>
    internal static string ComparerName<TKey, TValue>(Dictionary<TKey, TValue> map) where TKey : notnull
    {
        object? comparer = Comparer(map);
        if (comparer is null)
        {
            return "null";
        }

        Type type = comparer.GetType();
        return type.DeclaringType is null ? type.Name : type.DeclaringType.Name + "." + type.Name;
    }

    /// <summary>Массив бакетов. Значения в нём сдвинуты на единицу.</summary>
    internal static int[] Buckets<TKey, TValue>(Dictionary<TKey, TValue> map) where TKey : notnull
        => (int[])(Field(map, "_buckets").GetValue(map) ?? Array.Empty<int>());

    /// <summary>Записи словаря как массив объектов: тип записи приватный.</summary>
    internal static Array Entries<TKey, TValue>(Dictionary<TKey, TValue> map) where TKey : notnull
        => (Array)(Field(map, "_entries").GetValue(map) ?? Array.Empty<int>());

    /// <summary>Число занятых записей, включая удалённые.</summary>
    internal static int Count<TKey, TValue>(Dictionary<TKey, TValue> map) where TKey : notnull
        => (int)Field(map, "_count").GetValue(map)!;

    /// <summary>Поле next у записи по номеру.</summary>
    internal static int Next(Array entries, int index)
        => (int)EntryField(entries, "next").GetValue(entries.GetValue(index))!;

    /// <summary>Поле hashCode у записи по номеру.</summary>
    internal static uint HashCode(Array entries, int index)
        => (uint)EntryField(entries, "hashCode").GetValue(entries.GetValue(index))!;

    /// <summary>Ключ записи по номеру.</summary>
    internal static object? Key(Array entries, int index)
        => EntryField(entries, "key").GetValue(entries.GetValue(index));

    private static FieldInfo Field(object target, string name)
        => target.GetType().GetField(name, Flags)
           ?? throw new InvalidOperationException("Поле " + name + " не найдено: реализация словаря изменилась");

    private static FieldInfo EntryField(Array entries, string name)
        => entries.GetType().GetElementType()!.GetField(name, Flags | BindingFlags.Public)
           ?? throw new InvalidOperationException("Поле записи " + name + " не найдено: реализация словаря изменилась");
}
