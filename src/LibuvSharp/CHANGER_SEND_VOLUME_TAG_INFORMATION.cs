using System.Runtime.InteropServices;

namespace LibuvSharp;

public unsafe partial class CHANGER_SEND_VOLUME_TAG_INFORMATION : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 52)]
    public partial struct __Internal
    {
        internal       global::LibuvSharp.CHANGER_ELEMENT.__Internal StartingElement;
        internal       uint                                          ActionCode;
        internal fixed byte                                          VolumeIDTemplate[40];
    }

    public IntPtr __Instance { get; protected set; }

    internal new static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.CHANGER_SEND_VOLUME_TAG_INFORMATION> NativeToManagedMap =
        new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LibuvSharp.CHANGER_SEND_VOLUME_TAG_INFORMATION>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, global::LibuvSharp.CHANGER_SEND_VOLUME_TAG_INFORMATION managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::LibuvSharp.CHANGER_SEND_VOLUME_TAG_INFORMATION managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static CHANGER_SEND_VOLUME_TAG_INFORMATION __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new CHANGER_SEND_VOLUME_TAG_INFORMATION(native.ToPointer(), skipVTables);
    }

    internal static CHANGER_SEND_VOLUME_TAG_INFORMATION __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (CHANGER_SEND_VOLUME_TAG_INFORMATION)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static CHANGER_SEND_VOLUME_TAG_INFORMATION __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new CHANGER_SEND_VOLUME_TAG_INFORMATION(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private CHANGER_SEND_VOLUME_TAG_INFORMATION(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected CHANGER_SEND_VOLUME_TAG_INFORMATION(void* native, bool skipVTables = false)
    {
        if (native == null)
            return;
        __Instance = new IntPtr(native);
    }

    public void Dispose()
    {
        Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
    }

    partial void DisposePartial(bool disposing);

    protected internal virtual void Dispose(bool disposing, bool callNativeDtor )
    {
        if (__Instance == IntPtr.Zero)
            return;
        NativeToManagedMap.TryRemove(__Instance, out _);
        DisposePartial(disposing);
        if (__ownsNativeInstance)
            Marshal.FreeHGlobal(__Instance);
        __Instance = IntPtr.Zero;
    }

    public global::LibuvSharp.CHANGER_ELEMENT StartingElement
    {
        get => global::LibuvSharp.CHANGER_ELEMENT.__CreateInstance(new IntPtr(&((__Internal*)__Instance)->StartingElement));

        set
        {
            if (ReferenceEquals(value, null))
                throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
            ((__Internal*)__Instance)->StartingElement = *(global::LibuvSharp.CHANGER_ELEMENT.__Internal*) value.__Instance;
        }
    }

    public uint ActionCode
    {
        get => ((__Internal*)__Instance)->ActionCode;

        set => ((__Internal*)__Instance)->ActionCode = value;
    }

    public byte[] VolumeIDTemplate
    {
        get => CppSharp.Runtime.MarshalUtil.GetArray<byte>(((__Internal*)__Instance)->VolumeIDTemplate, 40);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 40; i++)
                    ((__Internal*)__Instance)->VolumeIDTemplate[i] = value[i];
            }
        }
    }
}