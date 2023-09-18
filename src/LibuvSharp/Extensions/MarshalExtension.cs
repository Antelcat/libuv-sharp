using System.Runtime.InteropServices;
using System.Text;

namespace LibuvSharp.Extensions;

internal static class MarshalExtension
{
    public static nint CopyToPointer(this string? str,IntPtr? position = null)
    {
        if (str == null) return IntPtr.Zero;
        var bytes   = Encoding.UTF8.GetBytes(str);
        position ??= Marshal.AllocHGlobal(bytes.Length + 1);
        Marshal.Copy(bytes, 0, position.Value, bytes.Length);
        Marshal.WriteByte(position.Value + bytes.Length, 0);
        return position.Value;
    }
    
    public static nint CopyToPointer(this string[]? arr,IntPtr? position = null)
    {
        if (arr is not { Length: > 0 }) return IntPtr.Zero;
        unsafe
        {
            var start = position ??= Marshal.AllocHGlobal(sizeof(sbyte*) * arr.Length);
            foreach (var s in arr)
            {
                var ptr = s.CopyToPointer();
                Marshal.WriteIntPtr(position.Value, ptr);
                position = IntPtr.Add(position.Value, sizeof(sbyte*));
            }
            return start;
        }
    }
}