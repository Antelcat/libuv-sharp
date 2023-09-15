using System.Runtime.InteropServices;

namespace LibuvSharp.Extensions;

internal static class MarshalExtension
{
    public static nint CopyToPointer(this string? str,IntPtr? position = null)
    {
        if (str == null) return IntPtr.Zero;
        var bytes   = System.Text.Encoding.UTF8.GetBytes(str);
        position ??= Marshal.AllocHGlobal(bytes.Length + 1);
        Marshal.Copy(bytes, 0, position.Value, bytes.Length);
        Marshal.WriteByte(position.Value + bytes.Length, 0);
        return position.Value;
    }
    
    public static nint CopyToPointer(this string[]? arr,IntPtr? position = null)
    {
        if (arr == null || arr.Length == 0) return IntPtr.Zero;
        var lists = arr.Select(s => System.Text.Encoding.UTF8.GetBytes(s)).ToList();
        var start = position ??= Marshal.AllocHGlobal(lists.Sum(x => x.Length + 1));
        foreach (var bytes in lists)
        {
            var length = bytes.Length;
            Marshal.Copy(bytes, 0, position.Value, length);
            Marshal.WriteByte(position.Value + length, 0);
            position = IntPtr.Add(position.Value, length + 1);
        }
        return start;
    }
}