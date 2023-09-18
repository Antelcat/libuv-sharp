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

    public static nint CopyToPointer(this string[]? args)
    {
        if (args == null)
        {
            return IntPtr.Zero;
        }

        unsafe
        {
            var arr = Marshal.AllocHGlobal((args.Length + 1) * sizeof(IntPtr));
            for (var i = 0; i < args.Length; i++)
            {
                Marshal.WriteIntPtr(arr, i * sizeof(IntPtr), Marshal.StringToHGlobalAnsi(args[i]));
            }
            Marshal.WriteIntPtr(arr, args.Length * sizeof(IntPtr), IntPtr.Zero);
            return arr;
        }
    }
}