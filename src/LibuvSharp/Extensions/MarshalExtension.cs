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
        if (arr == null || arr.Length <= 0) return IntPtr.Zero;
        var start = position ??= Marshal.AllocHGlobal(IntPtr.Size * arr.Length);
        foreach (var s in arr)
        {
            var ptr = s.CopyToPointer();
            Marshal.WriteIntPtr(position.Value, ptr);
            position = IntPtr.Add(position.Value, 1);
        }
        return start;
    }
}