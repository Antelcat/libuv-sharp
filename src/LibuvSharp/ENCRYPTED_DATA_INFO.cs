using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using CppSharp.Runtime;

namespace LibuvSharp;

public unsafe partial class ENCRYPTED_DATA_INFO : IDisposable
{
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public struct __Internal
    {
        internal       ulong  StartingFileOffset;
        internal       uint   OutputBufferOffset;
        internal       uint   BytesWithinFileSize;
        internal       uint   BytesWithinValidDataLength;
        internal       ushort CompressionFormat;
        internal       byte   DataUnitShift;
        internal       byte   ChunkShift;
        internal       byte   ClusterShift;
        internal       byte   EncryptionFormat;
        internal       ushort NumberOfDataBlocks;
        internal fixed uint   DataBlockSize[1];
    }

    public IntPtr __Instance { get; protected set; }

    internal static readonly ConcurrentDictionary<IntPtr, ENCRYPTED_DATA_INFO> NativeToManagedMap =
        new ConcurrentDictionary<IntPtr, ENCRYPTED_DATA_INFO>();

    internal static void __RecordNativeToManagedMapping(IntPtr native, ENCRYPTED_DATA_INFO managed)
    {
        NativeToManagedMap[native] = managed;
    }

    internal static bool __TryGetNativeToManagedMapping(IntPtr native, out ENCRYPTED_DATA_INFO managed)
    {
    
        return NativeToManagedMap.TryGetValue(native, out managed);
    }

    protected bool __ownsNativeInstance;

    internal static ENCRYPTED_DATA_INFO __CreateInstance(IntPtr native, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        return new ENCRYPTED_DATA_INFO(native.ToPointer(), skipVTables);
    }

    internal static ENCRYPTED_DATA_INFO __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
    {
        if (native == IntPtr.Zero)
            return null;
        if (__TryGetNativeToManagedMapping(native, out var managed))
            return (ENCRYPTED_DATA_INFO)managed;
        var result = __CreateInstance(native, skipVTables);
        if (saveInstance)
            __RecordNativeToManagedMapping(native, result);
        return result;
    }

    internal static ENCRYPTED_DATA_INFO __CreateInstance(__Internal native, bool skipVTables = false)
    {
        return new ENCRYPTED_DATA_INFO(native, skipVTables);
    }

    private static void* __CopyValue(__Internal native)
    {
        var ret = Marshal.AllocHGlobal(sizeof(__Internal));
        *(__Internal*) ret = native;
        return ret.ToPointer();
    }

    private ENCRYPTED_DATA_INFO(__Internal native, bool skipVTables = false)
        : this(__CopyValue(native), skipVTables)
    {
        __ownsNativeInstance = true;
        __RecordNativeToManagedMapping(__Instance, this);
    }

    protected ENCRYPTED_DATA_INFO(void* native, bool skipVTables = false)
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

    public ulong StartingFileOffset
    {
        get => ((__Internal*)__Instance)->StartingFileOffset;

        set => ((__Internal*)__Instance)->StartingFileOffset = value;
    }

    public uint OutputBufferOffset
    {
        get => ((__Internal*)__Instance)->OutputBufferOffset;

        set => ((__Internal*)__Instance)->OutputBufferOffset = value;
    }

    public uint BytesWithinFileSize
    {
        get => ((__Internal*)__Instance)->BytesWithinFileSize;

        set => ((__Internal*)__Instance)->BytesWithinFileSize = value;
    }

    public uint BytesWithinValidDataLength
    {
        get => ((__Internal*)__Instance)->BytesWithinValidDataLength;

        set => ((__Internal*)__Instance)->BytesWithinValidDataLength = value;
    }

    public ushort CompressionFormat
    {
        get => ((__Internal*)__Instance)->CompressionFormat;

        set => ((__Internal*)__Instance)->CompressionFormat = value;
    }

    public byte DataUnitShift
    {
        get => ((__Internal*)__Instance)->DataUnitShift;

        set => ((__Internal*)__Instance)->DataUnitShift = value;
    }

    public byte ChunkShift
    {
        get => ((__Internal*)__Instance)->ChunkShift;

        set => ((__Internal*)__Instance)->ChunkShift = value;
    }

    public byte ClusterShift
    {
        get => ((__Internal*)__Instance)->ClusterShift;

        set => ((__Internal*)__Instance)->ClusterShift = value;
    }

    public byte EncryptionFormat
    {
        get => ((__Internal*)__Instance)->EncryptionFormat;

        set => ((__Internal*)__Instance)->EncryptionFormat = value;
    }

    public ushort NumberOfDataBlocks
    {
        get => ((__Internal*)__Instance)->NumberOfDataBlocks;

        set => ((__Internal*)__Instance)->NumberOfDataBlocks = value;
    }

    public uint[] DataBlockSize
    {
        get => MarshalUtil.GetArray<uint>(((__Internal*)__Instance)->DataBlockSize, 1);

        set
        {
            if (value != null)
            {
                for (var i = 0; i < 1; i++)
                    ((__Internal*)__Instance)->DataBlockSize[i] = value[i];
            }
        }
    }
}