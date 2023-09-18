using System.Runtime.InteropServices;

public partial class RTL_CRITICAL_SECTION
{
    [StructLayout(LayoutKind.Sequential, Size = 40, Pack = 8)]
    public struct __Internal
    {
        internal IntPtr DebugInfo;
        internal int      LockCount;
        internal int      RecursionCount;
        internal IntPtr OwningThread;
        internal IntPtr LockSemaphore;
        internal ulong    SpinCount;
    }
}