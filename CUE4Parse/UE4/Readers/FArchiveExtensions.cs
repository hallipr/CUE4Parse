using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using CUE4Parse.UE4.Assets.Exports;

namespace CUE4Parse.UE4.Readers;
public static class ArchiveExtensions
{
    public static byte[] PeekBytes(this FArchive ar, int length)
    {
        var position = ar.Position;
        var result = ar.ReadBytes(length);
        ar.Position = position;
        return result;
    }

    public static T Peek<T>(this FArchive ar)
    {
        var position = ar.Position;
        var result = ar.Read<T>();
        ar.Position = position;
        return result;
    }

    public static T[] PeekArray<T>(this FArchive ar, int length)
    {
        var position = ar.Position;
        var result = ar.ReadArray<T>(length);
        ar.Position = position;
        return result;
    }

    public static void PeekArray<T>(this FArchive ar, T[] array)
    {
        var position = ar.Position;
        ar.ReadArray(array);
        ar.Position = position;
    }

    public static void PeekArray<T>(this FArchive ar, T[] array, Func<T> getter)
    {
        var position = ar.Position;
        ar.ReadArray(array, getter);
        ar.Position = position;
    }

    public static T[] PeekArray<T>(this FArchive ar, int length, Func<T> getter)
    {
        var position = ar.Position;
        var result = ar.ReadArray(length, getter);
        ar.Position = position;
        return result;
    }

    public static T[] PeekArray<T>(this FArchive ar, Func<T> getter)
    {
        var position = ar.Position;
        var result = ar.ReadArray(getter);
        ar.Position = position;
        return result;
    }

    public static T[] PeekArray<T>(this FArchive ar) where T : struct
    {
        var position = ar.Position;
        var result = ar.ReadArray<T>();
        ar.Position = position;
        return result;
    }

    public static T[] PeekBulkArray<T>(this FArchive ar, int elementSize, int elementCount, Func<T> getter)
    {
        var position = ar.Position;
        var result = ar.ReadBulkArray(elementSize, elementCount, getter);
        ar.Position = position;
        return result;
    }

    public static T[] PeekBulkArray<T>(this FArchive ar) where T : struct
    {
        var position = ar.Position;
        var result = ar.ReadBulkArray<T>();
        ar.Position = position;
        return result;
    }

    public static T[] PeekBulkArray<T>(this FArchive ar, Func<T> getter)
    {
        var position = ar.Position;
        var result = ar.ReadBulkArray(getter);
        ar.Position = position;
        return result;
    }

    public static Dictionary<TKey, TValue> PeekMap<TKey, TValue>(this FArchive ar, int length, Func<(TKey, TValue)> getter) where TKey : notnull
    {
        var position = ar.Position;
        var result = ar.ReadMap(length, getter);
        ar.Position = position;
        return result;
    }

    public static Dictionary<TKey, TValue> PeekMap<TKey, TValue>(this FArchive ar, Func<(TKey, TValue)> getter) where TKey : notnull
    {
        var position = ar.Position;
        var result = ar.ReadMap(getter);
        ar.Position = position;
        return result;
    }

    public static bool PeekBoolean(this FArchive ar)
    {
        var position = ar.Position;
        var result = ar.ReadBoolean();
        ar.Position = position;
        return result;
    }

    public static bool PeekFlag(this FArchive ar)
    {
        var position = ar.Position;
        var result = ar.ReadFlag();
        ar.Position = position;
        return result;
    }

    public static uint PeekIntPacked(this FArchive ar)
    {
        var position = ar.Position;
        var result = ar.ReadIntPacked();
        ar.Position = position;
        return result;
    }

    public static int Peek7BitEncodedInt(this FArchive ar)
    {
        var position = ar.Position;
        var result = ar.Read7BitEncodedInt();
        ar.Position = position;
        return result;
    }

    public static string PeekString(this FArchive ar)
    {
        var position = ar.Position;
        var result = ar.ReadString();
        ar.Position = position;
        return result;
    }

    public static string PeekFString(this FArchive ar)
    {
        var position = ar.Position;
        var result = ar.ReadFString();
        ar.Position = position;
        return result;
    }

    public static CUE4Parse.UE4.Objects.UObject.FName PeekFName(this FArchive ar)
    {
        var position = ar.Position;
        var result = ar.ReadFName();
        ar.Position = position;
        return result;
    }

    public static UObject? PeekUObject(this FArchive ar)
    {
        var position = ar.Position;
        var result = ar.ReadUObject();
        ar.Position = position;
        return result;
    }

    public static async Task<int> PeekAsync(this FArchive ar, byte[] buffer, int offset, int count)
    {
        var position = ar.Position;
        var result = await ar.ReadAsync(buffer, offset, count);
        ar.Position = position;
        return result;
    }

    public static async Task<int> PeekAsync(this FArchive ar, byte[] buffer, int offset, int count, CancellationToken cancellationToken)
    {
        var position = ar.Position;
        var result = await ar.ReadAsync(buffer, offset, count, cancellationToken);
        ar.Position = position;
        return result;
    }

    public static async Task<int> PeekAsync(this FArchive ar, Memory<byte> buffer, CancellationToken cancellationToken)
    {
        var position = ar.Position;
        var result = await ar.ReadAsync(buffer, cancellationToken);
        ar.Position = position;
        return result;
    }

    public static async ValueTask PeekExactlyAsync(this FArchive ar, Memory<byte> buffer, CancellationToken cancellationToken)
    {
        var position = ar.Position;
        await ar.ReadExactlyAsync(buffer, cancellationToken);
        ar.Position = position;
    }

    public static ValueTask PeekExactlyAsync(this FArchive ar, byte[] buffer, int offset, int count, CancellationToken cancellationToken)
    {
        var position = ar.Position;
        var result = ar.ReadExactlyAsync(buffer, offset, count, cancellationToken);
        ar.Position = position;
        return result;
    }

    public static async ValueTask<int> PeekAtLeastAsync(this FArchive ar, Memory<byte> buffer, int minimumBytes, bool throwOnEndOfStream, CancellationToken cancellationToken)
    {
        var position = ar.Position;
        var result = await ar.ReadAtLeastAsync(buffer, minimumBytes, throwOnEndOfStream, cancellationToken);
        ar.Position = position;
        return result;
    }

    public static int Peek(this FArchive ar, byte[] buffer, int offset, int count)
    {
        var position = ar.Position;
        var result = ar.Read(buffer, offset, count);
        ar.Position = position;
        return result;
    }

    public static int Peek(this FArchive ar, Span<byte> buffer)
    {
        var position = ar.Position;
        var result = ar.Read(buffer);
        ar.Position = position;
        return result;
    }

    public static int PeekByte(this FArchive ar)
    {
        var position = ar.Position;
        var result = ar.ReadByte();
        ar.Position = position;
        return result;
    }

    public static void PeekExactly(this FArchive ar, Span<byte> buffer)
    {
        var position = ar.Position;
        ar.ReadExactly(buffer);
        ar.Position = position;
    }

    public static void PeekExactly(this FArchive ar, byte[] buffer, int offset, int count)
    {
        var position = ar.Position;
        ar.ReadExactly(buffer, offset, count);
        ar.Position = position;
    }

    public static int PeekAtLeast(this FArchive ar, Span<byte> buffer, int minimumBytes, bool throwOnEndOfStream)
    {
        var position = ar.Position;
        var result = ar.ReadAtLeast(buffer, minimumBytes, throwOnEndOfStream);
        ar.Position = position;
        return result;
    }

}

