﻿using System.Runtime.InteropServices;
using System.Security;

namespace LibuvSharp;

public unsafe partial class uv
{
    public partial struct __Internal
    {
        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_version", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint UvVersion();

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_version_string", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr UvVersionString();

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_library_shutdown", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvLibraryShutdown();

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_replace_allocator", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvReplaceAllocator(IntPtr malloc_func, IntPtr realloc_func, IntPtr calloc_func, IntPtr free_func);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_default_loop", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr UvDefaultLoop();

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_loop_init", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvLoopInit(IntPtr loop);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_loop_close", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvLoopClose(IntPtr loop);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_loop_new", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr UvLoopNew();

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_loop_delete", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvLoopDelete(IntPtr _0);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_loop_size", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong UvLoopSize();

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_loop_alive", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvLoopAlive(IntPtr loop);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_loop_configure", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvLoopConfigure(IntPtr loop, global::LibuvSharp.UvLoopOption option);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_loop_fork", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvLoopFork(IntPtr loop);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_run", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvRun(IntPtr _0, global::LibuvSharp.UvRunMode mode);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_stop", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvStop(IntPtr _0);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_ref", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvRef(IntPtr _0);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_unref", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvUnref(IntPtr _0);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_has_ref", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvHasRef(IntPtr _0);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_update_time", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvUpdateTime(IntPtr _0);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_now", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong UvNow(IntPtr _0);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_backend_fd", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvBackendFd(IntPtr _0);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_backend_timeout", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvBackendTimeout(IntPtr _0);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_translate_sys_error", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvTranslateSysError(int sys_errno);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_strerror", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr UvStrerror(int err);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_strerror_r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern sbyte* UvStrerrorR(int err, sbyte* buf, ulong buflen);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_err_name", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr UvErrName(int err);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_err_name_r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern sbyte* UvErrNameR(int err, sbyte* buf, ulong buflen);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_shutdown", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvShutdown(IntPtr req, IntPtr handle, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_handle_size", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong UvHandleSize(global::LibuvSharp.UvHandleType type);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_handle_get_type", CallingConvention = CallingConvention.Cdecl)]
        internal static extern global::LibuvSharp.UvHandleType UvHandleGetType(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_handle_type_name", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr UvHandleTypeName(global::LibuvSharp.UvHandleType type);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_handle_get_data", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr UvHandleGetData(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_handle_get_loop", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr UvHandleGetLoop(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_handle_set_data", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvHandleSetData(IntPtr handle, IntPtr data);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_req_size", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong UvReqSize(global::LibuvSharp.UvReqType type);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_req_get_data", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr UvReqGetData(IntPtr req);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_req_set_data", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvReqSetData(IntPtr req, IntPtr data);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_req_get_type", CallingConvention = CallingConvention.Cdecl)]
        internal static extern global::LibuvSharp.UvReqType UvReqGetType(IntPtr req);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_req_type_name", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr UvReqTypeName(global::LibuvSharp.UvReqType type);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_is_active", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvIsActive(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_walk", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvWalk(IntPtr loop, IntPtr walk_cb, IntPtr arg);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_print_all_handles", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvPrintAllHandles(IntPtr loop, IntPtr stream);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_print_active_handles", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvPrintActiveHandles(IntPtr loop, IntPtr stream);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_close", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvClose(IntPtr handle, IntPtr close_cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_send_buffer_size", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvSendBufferSize(IntPtr handle, int* value);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_recv_buffer_size", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvRecvBufferSize(IntPtr handle, int* value);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fileno", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFileno(IntPtr handle, IntPtr* fd);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_buf_init", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvBufInit(IntPtr @return, sbyte* @base, uint len);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_pipe", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvPipe(int[] fds, int read_flags, int write_flags);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_socketpair", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvSocketpair(int type, int protocol, ulong[] socket_vector, int flags0, int flags1);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_stream_get_write_queue_size", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong UvStreamGetWriteQueueSize(IntPtr stream);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_listen", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvListen(IntPtr stream, int backlog, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_accept", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvAccept(IntPtr server, IntPtr client);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_read_start", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvReadStart(IntPtr _0, IntPtr alloc_cb, IntPtr read_cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_read_stop", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvReadStop(IntPtr _0);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_write", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvWrite(IntPtr req, IntPtr handle, global::LibuvSharp.UvBufT.__Internal[] bufs, uint nbufs, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_write2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvWrite2(IntPtr req, IntPtr handle, global::LibuvSharp.UvBufT.__Internal[] bufs, uint nbufs, IntPtr send_handle, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_try_write", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvTryWrite(IntPtr handle, global::LibuvSharp.UvBufT.__Internal[] bufs, uint nbufs);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_try_write2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvTryWrite2(IntPtr handle, global::LibuvSharp.UvBufT.__Internal[] bufs, uint nbufs, IntPtr send_handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_is_readable", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvIsReadable(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_is_writable", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvIsWritable(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_stream_set_blocking", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvStreamSetBlocking(IntPtr handle, int blocking);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_is_closing", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvIsClosing(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_tcp_init", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvTcpInit(IntPtr _0, IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_tcp_init_ex", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvTcpInitEx(IntPtr _0, IntPtr handle, uint flags);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_tcp_open", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvTcpOpen(IntPtr handle, ulong sock);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_tcp_nodelay", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvTcpNodelay(IntPtr handle, int enable);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_tcp_keepalive", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvTcpKeepalive(IntPtr handle, int enable, uint delay);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_tcp_simultaneous_accepts", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvTcpSimultaneousAccepts(IntPtr handle, int enable);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_tcp_close_reset", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvTcpCloseReset(IntPtr handle, IntPtr close_cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_udp_init", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvUdpInit(IntPtr _0, IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_udp_init_ex", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvUdpInitEx(IntPtr _0, IntPtr handle, uint flags);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_udp_open", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvUdpOpen(IntPtr handle, ulong sock);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_udp_set_membership", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvUdpSetMembership(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string multicast_addr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string interface_addr, global::LibuvSharp.UvMembership membership);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_udp_set_source_membership", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvUdpSetSourceMembership(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string multicast_addr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string interface_addr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string source_addr, global::LibuvSharp.UvMembership membership);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_udp_set_multicast_loop", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvUdpSetMulticastLoop(IntPtr handle, int on);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_udp_set_multicast_ttl", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvUdpSetMulticastTtl(IntPtr handle, int ttl);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_udp_set_multicast_interface", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvUdpSetMulticastInterface(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string interface_addr);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_udp_set_broadcast", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvUdpSetBroadcast(IntPtr handle, int on);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_udp_set_ttl", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvUdpSetTtl(IntPtr handle, int ttl);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_udp_using_recvmmsg", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvUdpUsingRecvmmsg(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_udp_recv_stop", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvUdpRecvStop(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_udp_get_send_queue_size", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong UvUdpGetSendQueueSize(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_udp_get_send_queue_count", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong UvUdpGetSendQueueCount(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_tty_init", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvTtyInit(IntPtr _0, IntPtr _1, int fd, int readable);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_tty_set_mode", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvTtySetMode(IntPtr _0, global::LibuvSharp.UvTtyModeT mode);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_tty_reset_mode", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvTtyResetMode();

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_tty_get_winsize", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvTtyGetWinsize(IntPtr _0, int* width, int* height);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_tty_set_vterm_state", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvTtySetVtermState(global::LibuvSharp.UvTtyVtermstateT state);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_tty_get_vterm_state", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvTtyGetVtermState(global::LibuvSharp.UvTtyVtermstateT* state);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "?uv_tty_set_mode@@YAHPEAUuv_tty_s@@H@Z", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvTtySetMode_1(IntPtr handle, int mode);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_guess_handle", CallingConvention = CallingConvention.Cdecl)]
        internal static extern global::LibuvSharp.UvHandleType UvGuessHandle(int file);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_pipe_init", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvPipeInit(IntPtr _0, IntPtr handle, int ipc);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_pipe_open", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvPipeOpen(IntPtr _0, int file);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_pipe_bind", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvPipeBind(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string name);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_pipe_bind2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvPipeBind2(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string name, ulong namelen, uint flags);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_pipe_connect", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvPipeConnect(IntPtr req, IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string name, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_pipe_connect2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvPipeConnect2(IntPtr req, IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string name, ulong namelen, uint flags, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_pipe_getsockname", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvPipeGetsockname(IntPtr handle, sbyte* buffer, ulong* size);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_pipe_getpeername", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvPipeGetpeername(IntPtr handle, sbyte* buffer, ulong* size);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_pipe_pending_instances", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvPipePendingInstances(IntPtr handle, int count);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_pipe_pending_count", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvPipePendingCount(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_pipe_pending_type", CallingConvention = CallingConvention.Cdecl)]
        internal static extern global::LibuvSharp.UvHandleType UvPipePendingType(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_pipe_chmod", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvPipeChmod(IntPtr handle, int flags);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_poll_init", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvPollInit(IntPtr loop, IntPtr handle, int fd);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_poll_init_socket", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvPollInitSocket(IntPtr loop, IntPtr handle, ulong socket);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_poll_start", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvPollStart(IntPtr handle, int events, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_poll_stop", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvPollStop(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_prepare_init", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvPrepareInit(IntPtr _0, IntPtr prepare);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_prepare_start", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvPrepareStart(IntPtr prepare, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_prepare_stop", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvPrepareStop(IntPtr prepare);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_check_init", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvCheckInit(IntPtr _0, IntPtr check);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_check_start", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvCheckStart(IntPtr check, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_check_stop", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvCheckStop(IntPtr check);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_idle_init", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvIdleInit(IntPtr _0, IntPtr idle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_idle_start", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvIdleStart(IntPtr idle, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_idle_stop", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvIdleStop(IntPtr idle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_async_init", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvAsyncInit(IntPtr _0, IntPtr async, IntPtr async_cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_async_send", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvAsyncSend(IntPtr async);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_timer_init", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvTimerInit(IntPtr _0, IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_timer_start", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvTimerStart(IntPtr handle, IntPtr cb, ulong timeout, ulong repeat);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_timer_stop", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvTimerStop(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_timer_again", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvTimerAgain(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_timer_set_repeat", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvTimerSetRepeat(IntPtr handle, ulong repeat);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_timer_get_repeat", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong UvTimerGetRepeat(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_timer_get_due_in", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong UvTimerGetDueIn(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_spawn", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvSpawn(IntPtr loop, IntPtr handle, IntPtr options);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_process_kill", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvProcessKill(IntPtr _0, int signum);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_kill", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvKill(int pid, int signum);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_process_get_pid", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvProcessGetPid(IntPtr _0);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_queue_work", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvQueueWork(IntPtr loop, IntPtr req, IntPtr work_cb, IntPtr after_work_cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_cancel", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvCancel(IntPtr req);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_setup_args", CallingConvention = CallingConvention.Cdecl)]
        internal static extern sbyte** UvSetupArgs(int argc, sbyte** argv);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_get_process_title", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvGetProcessTitle(sbyte* buffer, ulong size);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_set_process_title", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvSetProcessTitle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string title);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_resident_set_memory", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvResidentSetMemory(ulong* rss);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_uptime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvUptime(double* uptime);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_get_osfhandle", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr UvGetOsfhandle(int fd);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_open_osfhandle", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvOpenOsfhandle(IntPtr os_fd);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_getrusage", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvGetrusage(IntPtr rusage);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_os_homedir", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvOsHomedir(sbyte* buffer, ulong* size);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_os_tmpdir", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvOsTmpdir(sbyte* buffer, ulong* size);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_os_get_passwd", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvOsGetPasswd(IntPtr pwd);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_os_free_passwd", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvOsFreePasswd(IntPtr pwd);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_os_get_passwd2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvOsGetPasswd2(IntPtr pwd, byte uid);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_os_get_group", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvOsGetGroup(IntPtr grp, byte gid);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_os_free_group", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvOsFreeGroup(IntPtr grp);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_os_getpid", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvOsGetpid();

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_os_getppid", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvOsGetppid();

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_os_getpriority", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvOsGetpriority(int pid, int* priority);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_os_setpriority", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvOsSetpriority(int pid, int priority);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_available_parallelism", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint UvAvailableParallelism();

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_cpu_info", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvCpuInfo(IntPtr cpu_infos, int* count);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_free_cpu_info", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvFreeCpuInfo(IntPtr cpu_infos, int count);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_cpumask_size", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvCpumaskSize();

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_interface_addresses", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvInterfaceAddresses(IntPtr addresses, int* count);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_free_interface_addresses", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvFreeInterfaceAddresses(IntPtr addresses, int count);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_os_environ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvOsEnviron(IntPtr envitems, int* count);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_os_free_environ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvOsFreeEnviron(IntPtr envitems, int count);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_os_getenv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvOsGetenv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string name, sbyte* buffer, ulong* size);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_os_setenv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvOsSetenv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string value);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_os_unsetenv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvOsUnsetenv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string name);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_os_gethostname", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvOsGethostname(sbyte* buffer, ulong* size);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_os_uname", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvOsUname(IntPtr buffer);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_metrics_info", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvMetricsInfo(IntPtr loop, IntPtr metrics);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_metrics_idle_time", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong UvMetricsIdleTime(IntPtr loop);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_get_type", CallingConvention = CallingConvention.Cdecl)]
        internal static extern global::LibuvSharp.UvFsType UvFsGetType(IntPtr _0);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_get_result", CallingConvention = CallingConvention.Cdecl)]
        internal static extern long UvFsGetResult(IntPtr _0);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_get_system_error", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsGetSystemError(IntPtr _0);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_get_ptr", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr UvFsGetPtr(IntPtr _0);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_get_path", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr UvFsGetPath(IntPtr _0);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_get_statbuf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr UvFsGetStatbuf(IntPtr _0);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_req_cleanup", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvFsReqCleanup(IntPtr req);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_close", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsClose(IntPtr loop, IntPtr req, int file, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_open", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsOpen(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, int flags, int mode, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_read", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsRead(IntPtr loop, IntPtr req, int file, global::LibuvSharp.UvBufT.__Internal[] bufs, uint nbufs, long offset, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_unlink", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsUnlink(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_write", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsWrite(IntPtr loop, IntPtr req, int file, global::LibuvSharp.UvBufT.__Internal[] bufs, uint nbufs, long offset, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_copyfile", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsCopyfile(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string new_path, int flags, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_mkdir", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsMkdir(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, int mode, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_mkdtemp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsMkdtemp(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string tpl, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_mkstemp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsMkstemp(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string tpl, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_rmdir", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsRmdir(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_scandir", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsScandir(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, int flags, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_scandir_next", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsScandirNext(IntPtr req, IntPtr ent);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_opendir", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsOpendir(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_readdir", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsReaddir(IntPtr loop, IntPtr req, IntPtr dir, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_closedir", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsClosedir(IntPtr loop, IntPtr req, IntPtr dir, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_stat", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsStat(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_fstat", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsFstat(IntPtr loop, IntPtr req, int file, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_rename", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsRename(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string new_path, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_fsync", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsFsync(IntPtr loop, IntPtr req, int file, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_fdatasync", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsFdatasync(IntPtr loop, IntPtr req, int file, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_ftruncate", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsFtruncate(IntPtr loop, IntPtr req, int file, long offset, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_sendfile", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsSendfile(IntPtr loop, IntPtr req, int out_fd, int in_fd, long in_offset, ulong length, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_access", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsAccess(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, int mode, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_chmod", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsChmod(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, int mode, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_utime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsUtime(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, double atime, double mtime, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_futime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsFutime(IntPtr loop, IntPtr req, int file, double atime, double mtime, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_lutime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsLutime(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, double atime, double mtime, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_lstat", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsLstat(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_link", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsLink(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string new_path, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_symlink", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsSymlink(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string new_path, int flags, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_readlink", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsReadlink(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_realpath", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsRealpath(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_fchmod", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsFchmod(IntPtr loop, IntPtr req, int file, int mode, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_chown", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsChown(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, byte uid, byte gid, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_fchown", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsFchown(IntPtr loop, IntPtr req, int file, byte uid, byte gid, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_lchown", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsLchown(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, byte uid, byte gid, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_statfs", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsStatfs(IntPtr loop, IntPtr req, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_poll_init", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsPollInit(IntPtr loop, IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_poll_start", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsPollStart(IntPtr handle, IntPtr poll_cb, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, uint interval);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_poll_stop", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsPollStop(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_poll_getpath", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsPollGetpath(IntPtr handle, sbyte* buffer, ulong* size);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_signal_init", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvSignalInit(IntPtr loop, IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_signal_start", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvSignalStart(IntPtr handle, IntPtr signal_cb, int signum);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_signal_start_oneshot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvSignalStartOneshot(IntPtr handle, IntPtr signal_cb, int signum);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_signal_stop", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvSignalStop(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_loadavg", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvLoadavg(double[] avg);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_event_init", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsEventInit(IntPtr loop, IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_event_start", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsEventStart(IntPtr handle, IntPtr cb, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string path, uint flags);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_event_stop", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsEventStop(IntPtr handle);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_fs_event_getpath", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvFsEventGetpath(IntPtr handle, sbyte* buffer, ulong* size);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_inet_ntop", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvInetNtop(int af, IntPtr src, sbyte* dst, ulong size);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_inet_pton", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvInetPton(int af, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string src, IntPtr dst);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_random", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvRandom(IntPtr loop, IntPtr req, IntPtr buf, ulong buflen, uint flags, IntPtr cb);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_if_indextoname", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvIfIndextoname(uint ifindex, sbyte* buffer, ulong* size);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_if_indextoiid", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvIfIndextoiid(uint ifindex, sbyte* buffer, ulong* size);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_exepath", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvExepath(sbyte* buffer, ulong* size);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_cwd", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvCwd(sbyte* buffer, ulong* size);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_chdir", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvChdir([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string dir);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_get_free_memory", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong UvGetFreeMemory();

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_get_total_memory", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong UvGetTotalMemory();

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_get_constrained_memory", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong UvGetConstrainedMemory();

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_get_available_memory", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong UvGetAvailableMemory();

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_clock_gettime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvClockGettime(global::LibuvSharp.UvClockId clock_id, IntPtr ts);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_hrtime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ulong UvHrtime();

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_sleep", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvSleep(uint msec);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_disable_stdio_inheritance", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvDisableStdioInheritance();

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_dlopen", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvDlopen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string filename, IntPtr lib);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_dlclose", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvDlclose(IntPtr lib);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_dlsym", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvDlsym(IntPtr lib, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string name, IntPtr* ptr);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_dlerror", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr UvDlerror(IntPtr lib);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_rwlock_init", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvRwlockInit(IntPtr rwlock);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_rwlock_destroy", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvRwlockDestroy(IntPtr rwlock);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_rwlock_rdlock", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvRwlockRdlock(IntPtr rwlock);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_rwlock_tryrdlock", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvRwlockTryrdlock(IntPtr rwlock);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_rwlock_rdunlock", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvRwlockRdunlock(IntPtr rwlock);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_rwlock_wrlock", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvRwlockWrlock(IntPtr rwlock);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_rwlock_trywrlock", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvRwlockTrywrlock(IntPtr rwlock);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_rwlock_wrunlock", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvRwlockWrunlock(IntPtr rwlock);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_sem_init", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvSemInit(IntPtr* sem, uint value);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_sem_destroy", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvSemDestroy(IntPtr* sem);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_sem_post", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvSemPost(IntPtr* sem);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_sem_wait", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvSemWait(IntPtr* sem);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_sem_trywait", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvSemTrywait(IntPtr* sem);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_cond_init", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvCondInit(IntPtr cond);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_cond_destroy", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvCondDestroy(IntPtr cond);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_cond_signal", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvCondSignal(IntPtr cond);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_cond_broadcast", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvCondBroadcast(IntPtr cond);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_barrier_init", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvBarrierInit(IntPtr barrier, uint count);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_barrier_destroy", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvBarrierDestroy(IntPtr barrier);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_barrier_wait", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvBarrierWait(IntPtr barrier);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_once", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvOnce(IntPtr guard, IntPtr callback);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_key_create", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvKeyCreate(IntPtr key);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_key_delete", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvKeyDelete(IntPtr key);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_key_get", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr UvKeyGet(IntPtr key);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_key_set", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvKeySet(IntPtr key, IntPtr value);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_gettimeofday", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvGettimeofday(IntPtr tv);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_thread_create", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvThreadCreate(IntPtr* tid, IntPtr entry, IntPtr arg);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_thread_create_ex", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvThreadCreateEx(IntPtr* tid, IntPtr @params, IntPtr entry, IntPtr arg);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_thread_setaffinity", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvThreadSetaffinity(IntPtr* tid, sbyte* cpumask, sbyte* oldmask, ulong mask_size);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_thread_getaffinity", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvThreadGetaffinity(IntPtr* tid, sbyte* cpumask, ulong mask_size);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_thread_getcpu", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvThreadGetcpu();

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_thread_self", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr UvThreadSelf();

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_thread_join", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvThreadJoin(IntPtr* tid);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_thread_equal", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int UvThreadEqual(IntPtr* t1, IntPtr* t2);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_loop_get_data", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr UvLoopGetData(IntPtr _0);

        [SuppressUnmanagedCodeSecurity, DllImport("LibuvSharp", EntryPoint = "uv_loop_set_data", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void UvLoopSetData(IntPtr _0, IntPtr data);
    }

    public static uint UvVersion()
    {
        var ___ret = __Internal.UvVersion();
        return ___ret;
    }

    public static string UvVersionString()
    {
        var ___ret = __Internal.UvVersionString();
        return CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ___ret);
    }

    public static void UvLibraryShutdown()
    {
        __Internal.UvLibraryShutdown();
    }

    public static int UvReplaceAllocator(global::LibuvSharp.UvMallocFunc malloc_func, global::LibuvSharp.UvReallocFunc realloc_func, global::LibuvSharp.UvCallocFunc calloc_func, global::LibuvSharp.UvFreeFunc free_func)
    {
        var __arg0 = malloc_func == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(malloc_func);
        var __arg1 = realloc_func == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(realloc_func);
        var __arg2 = calloc_func == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(calloc_func);
        var __arg3 = free_func == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(free_func);
        var ___ret = __Internal.UvReplaceAllocator(__arg0, __arg1, __arg2, __arg3);
        return ___ret;
    }

    public static global::LibuvSharp.UvLoopS UvDefaultLoop()
    {
        var ___ret    = __Internal.UvDefaultLoop();
        var __result0 = global::LibuvSharp.UvLoopS.__GetOrCreateInstance(___ret, false);
        return __result0;
    }

    public static int UvLoopInit(global::LibuvSharp.UvLoopS loop)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var ___ret = __Internal.UvLoopInit(__arg0);
        return ___ret;
    }

    public static int UvLoopClose(global::LibuvSharp.UvLoopS loop)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var ___ret = __Internal.UvLoopClose(__arg0);
        return ___ret;
    }

    public static global::LibuvSharp.UvLoopS UvLoopNew()
    {
        var ___ret    = __Internal.UvLoopNew();
        var __result0 = global::LibuvSharp.UvLoopS.__GetOrCreateInstance(___ret, false);
        return __result0;
    }

    public static void UvLoopDelete(global::LibuvSharp.UvLoopS _0)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        __Internal.UvLoopDelete(__arg0);
    }

    public static ulong UvLoopSize()
    {
        var ___ret = __Internal.UvLoopSize();
        return ___ret;
    }

    public static int UvLoopAlive(global::LibuvSharp.UvLoopS loop)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var ___ret = __Internal.UvLoopAlive(__arg0);
        return ___ret;
    }

    public static int UvLoopConfigure(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvLoopOption option)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var ___ret = __Internal.UvLoopConfigure(__arg0, option);
        return ___ret;
    }

    public static int UvLoopFork(global::LibuvSharp.UvLoopS loop)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var ___ret = __Internal.UvLoopFork(__arg0);
        return ___ret;
    }

    public static int UvRun(global::LibuvSharp.UvLoopS _0, global::LibuvSharp.UvRunMode mode)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var ___ret = __Internal.UvRun(__arg0, mode);
        return ___ret;
    }

    public static void UvStop(global::LibuvSharp.UvLoopS _0)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        __Internal.UvStop(__arg0);
    }

    public static void UvRef(global::LibuvSharp.UvHandleS _0)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        __Internal.UvRef(__arg0);
    }

    public static void UvUnref(global::LibuvSharp.UvHandleS _0)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        __Internal.UvUnref(__arg0);
    }

    public static int UvHasRef(global::LibuvSharp.UvHandleS _0)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var ___ret = __Internal.UvHasRef(__arg0);
        return ___ret;
    }

    public static void UvUpdateTime(global::LibuvSharp.UvLoopS _0)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        __Internal.UvUpdateTime(__arg0);
    }

    public static ulong UvNow(global::LibuvSharp.UvLoopS _0)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var ___ret = __Internal.UvNow(__arg0);
        return ___ret;
    }

    public static int UvBackendFd(global::LibuvSharp.UvLoopS _0)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var ___ret = __Internal.UvBackendFd(__arg0);
        return ___ret;
    }

    public static int UvBackendTimeout(global::LibuvSharp.UvLoopS _0)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var ___ret = __Internal.UvBackendTimeout(__arg0);
        return ___ret;
    }

    public static int UvTranslateSysError(int sys_errno)
    {
        var ___ret = __Internal.UvTranslateSysError(sys_errno);
        return ___ret;
    }

    public static string UvStrerror(int err)
    {
        var ___ret = __Internal.UvStrerror(err);
        return CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ___ret);
    }

    public static sbyte* UvStrerrorR(int err, sbyte* buf, ulong buflen)
    {
        var ___ret = __Internal.UvStrerrorR(err, buf, buflen);
        return ___ret;
    }

    public static string UvErrName(int err)
    {
        var ___ret = __Internal.UvErrName(err);
        return CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ___ret);
    }

    public static sbyte* UvErrNameR(int err, sbyte* buf, ulong buflen)
    {
        var ___ret = __Internal.UvErrNameR(err, buf, buflen);
        return ___ret;
    }

    public static int UvShutdown(global::LibuvSharp.UvShutdownS req, global::LibuvSharp.UvStreamS handle, global::LibuvSharp.UvShutdownCb cb)
    {
        var __arg0 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg1 = handle is null ? IntPtr.Zero : handle.__Instance;
        var __arg2 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvShutdown(__arg0, __arg1, __arg2);
        return ___ret;
    }

    public static ulong UvHandleSize(global::LibuvSharp.UvHandleType type)
    {
        var ___ret = __Internal.UvHandleSize(type);
        return ___ret;
    }

    public static global::LibuvSharp.UvHandleType UvHandleGetType(global::LibuvSharp.UvHandleS handle)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvHandleGetType(__arg0);
        return ___ret;
    }

    public static string UvHandleTypeName(global::LibuvSharp.UvHandleType type)
    {
        var ___ret = __Internal.UvHandleTypeName(type);
        return CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ___ret);
    }

    public static IntPtr UvHandleGetData(global::LibuvSharp.UvHandleS handle)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvHandleGetData(__arg0);
        return ___ret;
    }

    public static global::LibuvSharp.UvLoopS UvHandleGetLoop(global::LibuvSharp.UvHandleS handle)
    {
        var __arg0    = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret    = __Internal.UvHandleGetLoop(__arg0);
        var __result0 = global::LibuvSharp.UvLoopS.__GetOrCreateInstance(___ret, false);
        return __result0;
    }

    public static void UvHandleSetData(global::LibuvSharp.UvHandleS handle, IntPtr data)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        __Internal.UvHandleSetData(__arg0, data);
    }

    public static ulong UvReqSize(global::LibuvSharp.UvReqType type)
    {
        var ___ret = __Internal.UvReqSize(type);
        return ___ret;
    }

    public static IntPtr UvReqGetData(global::LibuvSharp.UvReqS req)
    {
        var __arg0 = req is null ? IntPtr.Zero : req.__Instance;
        var ___ret = __Internal.UvReqGetData(__arg0);
        return ___ret;
    }

    public static void UvReqSetData(global::LibuvSharp.UvReqS req, IntPtr data)
    {
        var __arg0 = req is null ? IntPtr.Zero : req.__Instance;
        __Internal.UvReqSetData(__arg0, data);
    }

    public static global::LibuvSharp.UvReqType UvReqGetType(global::LibuvSharp.UvReqS req)
    {
        var __arg0 = req is null ? IntPtr.Zero : req.__Instance;
        var ___ret = __Internal.UvReqGetType(__arg0);
        return ___ret;
    }

    public static string UvReqTypeName(global::LibuvSharp.UvReqType type)
    {
        var ___ret = __Internal.UvReqTypeName(type);
        return CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ___ret);
    }

    public static int UvIsActive(global::LibuvSharp.UvHandleS handle)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvIsActive(__arg0);
        return ___ret;
    }

    public static void UvWalk(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvWalkCb walk_cb, IntPtr arg)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = walk_cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(walk_cb);
        __Internal.UvWalk(__arg0, __arg1, arg);
    }

    public static void UvPrintAllHandles(global::LibuvSharp.UvLoopS loop, global::System.IntPtr stream)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        __Internal.UvPrintAllHandles(__arg0, stream);
    }

    public static void UvPrintActiveHandles(global::LibuvSharp.UvLoopS loop, global::System.IntPtr stream)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        __Internal.UvPrintActiveHandles(__arg0, stream);
    }

    public static void UvClose(global::LibuvSharp.UvHandleS handle, global::LibuvSharp.UvCloseCb close_cb)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var __arg1 = close_cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(close_cb);
        __Internal.UvClose(__arg0, __arg1);
    }

    public static int UvSendBufferSize(global::LibuvSharp.UvHandleS handle, ref int value)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        fixed (int* __value1 = &value)
        {
            var __arg1 = __value1;
            var ___ret = __Internal.UvSendBufferSize(__arg0, __arg1);
            return ___ret;
        }
    }

    public static int UvRecvBufferSize(global::LibuvSharp.UvHandleS handle, ref int value)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        fixed (int* __value1 = &value)
        {
            var __arg1 = __value1;
            var ___ret = __Internal.UvRecvBufferSize(__arg0, __arg1);
            return ___ret;
        }
    }

    public static int UvFileno(global::LibuvSharp.UvHandleS handle, IntPtr* fd)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvFileno(__arg0, fd);
        return ___ret;
    }

    public static global::LibuvSharp.UvBufT UvBufInit(sbyte* @base, uint len)
    {
        var ___ret = new global::LibuvSharp.UvBufT.__Internal();
        __Internal.UvBufInit(new IntPtr(&___ret), @base, len);
        return global::LibuvSharp.UvBufT.__CreateInstance(___ret);
    }

    public static int UvPipe(int[] fds, int read_flags, int write_flags)
    {
        if (fds == null || fds.Length != 2)
            throw new ArgumentOutOfRangeException("fds", "The dimensions of the provided array don't match the required size.");
        var ___ret = __Internal.UvPipe(fds, read_flags, write_flags);
        return ___ret;
    }

    public static int UvSocketpair(int type, int protocol, ulong[] socket_vector, int flags0, int flags1)
    {
        if (socket_vector == null || socket_vector.Length != 2)
            throw new ArgumentOutOfRangeException("socket_vector", "The dimensions of the provided array don't match the required size.");
        var ___ret = __Internal.UvSocketpair(type, protocol, socket_vector, flags0, flags1);
        return ___ret;
    }

    public static ulong UvStreamGetWriteQueueSize(global::LibuvSharp.UvStreamS stream)
    {
        var __arg0 = stream is null ? IntPtr.Zero : stream.__Instance;
        var ___ret = __Internal.UvStreamGetWriteQueueSize(__arg0);
        return ___ret;
    }

    public static int UvListen(global::LibuvSharp.UvStreamS stream, int backlog, global::LibuvSharp.UvConnectionCb cb)
    {
        var __arg0 = stream is null ? IntPtr.Zero : stream.__Instance;
        var __arg2 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvListen(__arg0, backlog, __arg2);
        return ___ret;
    }

    public static int UvAccept(global::LibuvSharp.UvStreamS server, global::LibuvSharp.UvStreamS client)
    {
        var __arg0 = server is null ? IntPtr.Zero : server.__Instance;
        var __arg1 = client is null ? IntPtr.Zero : client.__Instance;
        var ___ret = __Internal.UvAccept(__arg0, __arg1);
        return ___ret;
    }

    public static int UvReadStart(global::LibuvSharp.UvStreamS _0, global::LibuvSharp.UvAllocCb alloc_cb, global::LibuvSharp.UvReadCb read_cb)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var __arg1 = alloc_cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(alloc_cb);
        var __arg2 = read_cb  == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(read_cb);
        var ___ret = __Internal.UvReadStart(__arg0, __arg1, __arg2);
        return ___ret;
    }

    public static int UvReadStop(global::LibuvSharp.UvStreamS _0)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var ___ret = __Internal.UvReadStop(__arg0);
        return ___ret;
    }

    public static int UvWrite(global::LibuvSharp.UvWriteS req, global::LibuvSharp.UvStreamS handle, global::LibuvSharp.UvBufT[] bufs, uint nbufs, global::LibuvSharp.UvWriteCb cb)
    {
        var                                    __arg0 = req is null ? IntPtr.Zero : req.__Instance;
        var                                    __arg1 = handle is null ? IntPtr.Zero : handle.__Instance;
        global::LibuvSharp.UvBufT.__Internal[] __bufs;
        if (bufs == null)
            __bufs = null;
        else
        {
            __bufs = new global::LibuvSharp.UvBufT.__Internal[bufs.Length];
            for (var i = 0; i < __bufs.Length; i++)
            {
                var __element = bufs[i];
                __bufs[i] = __element is null ? new global::LibuvSharp.UvBufT.__Internal() : *(global::LibuvSharp.UvBufT.__Internal*) __element.__Instance;
            }
        }
        var __arg2 = __bufs;
        var __arg4 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvWrite(__arg0, __arg1, __arg2, nbufs, __arg4);
        return ___ret;
    }

    public static int UvWrite2(global::LibuvSharp.UvWriteS req, global::LibuvSharp.UvStreamS handle, global::LibuvSharp.UvBufT[] bufs, uint nbufs, global::LibuvSharp.UvStreamS send_handle, global::LibuvSharp.UvWriteCb cb)
    {
        var                                    __arg0 = req is null ? IntPtr.Zero : req.__Instance;
        var                                    __arg1 = handle is null ? IntPtr.Zero : handle.__Instance;
        global::LibuvSharp.UvBufT.__Internal[] __bufs;
        if (bufs == null)
            __bufs = null;
        else
        {
            __bufs = new global::LibuvSharp.UvBufT.__Internal[bufs.Length];
            for (var i = 0; i < __bufs.Length; i++)
            {
                var __element = bufs[i];
                __bufs[i] = __element is null ? new global::LibuvSharp.UvBufT.__Internal() : *(global::LibuvSharp.UvBufT.__Internal*) __element.__Instance;
            }
        }
        var __arg2 = __bufs;
        var __arg4 = send_handle is null ? IntPtr.Zero : send_handle.__Instance;
        var __arg5 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvWrite2(__arg0, __arg1, __arg2, nbufs, __arg4, __arg5);
        return ___ret;
    }

    public static int UvTryWrite(global::LibuvSharp.UvStreamS handle, global::LibuvSharp.UvBufT[] bufs, uint nbufs)
    {
        var                                    __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        global::LibuvSharp.UvBufT.__Internal[] __bufs;
        if (bufs == null)
            __bufs = null;
        else
        {
            __bufs = new global::LibuvSharp.UvBufT.__Internal[bufs.Length];
            for (var i = 0; i < __bufs.Length; i++)
            {
                var __element = bufs[i];
                __bufs[i] = __element is null ? new global::LibuvSharp.UvBufT.__Internal() : *(global::LibuvSharp.UvBufT.__Internal*) __element.__Instance;
            }
        }
        var __arg1 = __bufs;
        var ___ret = __Internal.UvTryWrite(__arg0, __arg1, nbufs);
        return ___ret;
    }

    public static int UvTryWrite2(global::LibuvSharp.UvStreamS handle, global::LibuvSharp.UvBufT[] bufs, uint nbufs, global::LibuvSharp.UvStreamS send_handle)
    {
        var                                    __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        global::LibuvSharp.UvBufT.__Internal[] __bufs;
        if (bufs == null)
            __bufs = null;
        else
        {
            __bufs = new global::LibuvSharp.UvBufT.__Internal[bufs.Length];
            for (var i = 0; i < __bufs.Length; i++)
            {
                var __element = bufs[i];
                __bufs[i] = __element is null ? new global::LibuvSharp.UvBufT.__Internal() : *(global::LibuvSharp.UvBufT.__Internal*) __element.__Instance;
            }
        }
        var __arg1 = __bufs;
        var __arg3 = send_handle is null ? IntPtr.Zero : send_handle.__Instance;
        var ___ret = __Internal.UvTryWrite2(__arg0, __arg1, nbufs, __arg3);
        return ___ret;
    }

    public static int UvIsReadable(global::LibuvSharp.UvStreamS handle)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvIsReadable(__arg0);
        return ___ret;
    }

    public static int UvIsWritable(global::LibuvSharp.UvStreamS handle)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvIsWritable(__arg0);
        return ___ret;
    }

    public static int UvStreamSetBlocking(global::LibuvSharp.UvStreamS handle, int blocking)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvStreamSetBlocking(__arg0, blocking);
        return ___ret;
    }

    public static int UvIsClosing(global::LibuvSharp.UvHandleS handle)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvIsClosing(__arg0);
        return ___ret;
    }

    public static int UvTcpInit(global::LibuvSharp.UvLoopS _0, global::LibuvSharp.UvTcpS handle)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var __arg1 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvTcpInit(__arg0, __arg1);
        return ___ret;
    }

    public static int UvTcpInitEx(global::LibuvSharp.UvLoopS _0, global::LibuvSharp.UvTcpS handle, uint flags)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var __arg1 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvTcpInitEx(__arg0, __arg1, flags);
        return ___ret;
    }

    public static int UvTcpOpen(global::LibuvSharp.UvTcpS handle, ulong sock)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvTcpOpen(__arg0, sock);
        return ___ret;
    }

    public static int UvTcpNodelay(global::LibuvSharp.UvTcpS handle, int enable)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvTcpNodelay(__arg0, enable);
        return ___ret;
    }

    public static int UvTcpKeepalive(global::LibuvSharp.UvTcpS handle, int enable, uint delay)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvTcpKeepalive(__arg0, enable, delay);
        return ___ret;
    }

    public static int UvTcpSimultaneousAccepts(global::LibuvSharp.UvTcpS handle, int enable)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvTcpSimultaneousAccepts(__arg0, enable);
        return ___ret;
    }

    public static int UvTcpCloseReset(global::LibuvSharp.UvTcpS handle, global::LibuvSharp.UvCloseCb close_cb)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var __arg1 = close_cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(close_cb);
        var ___ret = __Internal.UvTcpCloseReset(__arg0, __arg1);
        return ___ret;
    }

    public static int UvUdpInit(global::LibuvSharp.UvLoopS _0, global::LibuvSharp.UvUdpS handle)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var __arg1 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvUdpInit(__arg0, __arg1);
        return ___ret;
    }

    public static int UvUdpInitEx(global::LibuvSharp.UvLoopS _0, global::LibuvSharp.UvUdpS handle, uint flags)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var __arg1 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvUdpInitEx(__arg0, __arg1, flags);
        return ___ret;
    }

    public static int UvUdpOpen(global::LibuvSharp.UvUdpS handle, ulong sock)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvUdpOpen(__arg0, sock);
        return ___ret;
    }

    public static int UvUdpSetMembership(global::LibuvSharp.UvUdpS handle, string multicast_addr, string interface_addr, global::LibuvSharp.UvMembership membership)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvUdpSetMembership(__arg0, multicast_addr, interface_addr, membership);
        return ___ret;
    }

    public static int UvUdpSetSourceMembership(global::LibuvSharp.UvUdpS handle, string multicast_addr, string interface_addr, string source_addr, global::LibuvSharp.UvMembership membership)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvUdpSetSourceMembership(__arg0, multicast_addr, interface_addr, source_addr, membership);
        return ___ret;
    }

    public static int UvUdpSetMulticastLoop(global::LibuvSharp.UvUdpS handle, int on)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvUdpSetMulticastLoop(__arg0, on);
        return ___ret;
    }

    public static int UvUdpSetMulticastTtl(global::LibuvSharp.UvUdpS handle, int ttl)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvUdpSetMulticastTtl(__arg0, ttl);
        return ___ret;
    }

    public static int UvUdpSetMulticastInterface(global::LibuvSharp.UvUdpS handle, string interface_addr)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvUdpSetMulticastInterface(__arg0, interface_addr);
        return ___ret;
    }

    public static int UvUdpSetBroadcast(global::LibuvSharp.UvUdpS handle, int on)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvUdpSetBroadcast(__arg0, on);
        return ___ret;
    }

    public static int UvUdpSetTtl(global::LibuvSharp.UvUdpS handle, int ttl)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvUdpSetTtl(__arg0, ttl);
        return ___ret;
    }

    public static int UvUdpUsingRecvmmsg(global::LibuvSharp.UvUdpS handle)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvUdpUsingRecvmmsg(__arg0);
        return ___ret;
    }

    public static int UvUdpRecvStop(global::LibuvSharp.UvUdpS handle)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvUdpRecvStop(__arg0);
        return ___ret;
    }

    public static ulong UvUdpGetSendQueueSize(global::LibuvSharp.UvUdpS handle)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvUdpGetSendQueueSize(__arg0);
        return ___ret;
    }

    public static ulong UvUdpGetSendQueueCount(global::LibuvSharp.UvUdpS handle)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvUdpGetSendQueueCount(__arg0);
        return ___ret;
    }

    public static int UvTtyInit(global::LibuvSharp.UvLoopS _0, global::LibuvSharp.UvTtyS _1, int fd, int readable)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var __arg1 = _1 is null ? IntPtr.Zero : _1.__Instance;
        var ___ret = __Internal.UvTtyInit(__arg0, __arg1, fd, readable);
        return ___ret;
    }

    public static int UvTtySetMode(global::LibuvSharp.UvTtyS _0, global::LibuvSharp.UvTtyModeT mode)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var ___ret = __Internal.UvTtySetMode(__arg0, mode);
        return ___ret;
    }

    public static int UvTtyResetMode()
    {
        var ___ret = __Internal.UvTtyResetMode();
        return ___ret;
    }

    public static int UvTtyGetWinsize(global::LibuvSharp.UvTtyS _0, ref int width, ref int height)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        fixed (int* __width1 = &width)
        {
            var __arg1 = __width1;
            fixed (int* __height2 = &height)
            {
                var __arg2 = __height2;
                var ___ret = __Internal.UvTtyGetWinsize(__arg0, __arg1, __arg2);
                return ___ret;
            }
        }
    }

    public static void UvTtySetVtermState(global::LibuvSharp.UvTtyVtermstateT state)
    {
        __Internal.UvTtySetVtermState(state);
    }

    public static int UvTtyGetVtermState(ref global::LibuvSharp.UvTtyVtermstateT state)
    {
        fixed (global::LibuvSharp.UvTtyVtermstateT* __state0 = &state)
        {
            var __arg0 = __state0;
            var ___ret = __Internal.UvTtyGetVtermState(__arg0);
            return ___ret;
        }
    }

    public static int UvTtySetMode(global::LibuvSharp.UvTtyS handle, int mode)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvTtySetMode_1(__arg0, mode);
        return ___ret;
    }

    public static global::LibuvSharp.UvHandleType UvGuessHandle(int file)
    {
        var ___ret = __Internal.UvGuessHandle(file);
        return ___ret;
    }

    public static int UvPipeInit(global::LibuvSharp.UvLoopS _0, global::LibuvSharp.UvPipeS handle, int ipc)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var __arg1 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvPipeInit(__arg0, __arg1, ipc);
        return ___ret;
    }

    public static int UvPipeOpen(global::LibuvSharp.UvPipeS _0, int file)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var ___ret = __Internal.UvPipeOpen(__arg0, file);
        return ___ret;
    }

    public static int UvPipeBind(global::LibuvSharp.UvPipeS handle, string name)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvPipeBind(__arg0, name);
        return ___ret;
    }

    public static int UvPipeBind2(global::LibuvSharp.UvPipeS handle, string name, ulong namelen, uint flags)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvPipeBind2(__arg0, name, namelen, flags);
        return ___ret;
    }

    public static void UvPipeConnect(global::LibuvSharp.UvConnectS req, global::LibuvSharp.UvPipeS handle, string name, global::LibuvSharp.UvConnectCb cb)
    {
        var __arg0 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg1 = handle is null ? IntPtr.Zero : handle.__Instance;
        var __arg3 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        __Internal.UvPipeConnect(__arg0, __arg1, name, __arg3);
    }

    public static int UvPipeConnect2(global::LibuvSharp.UvConnectS req, global::LibuvSharp.UvPipeS handle, string name, ulong namelen, uint flags, global::LibuvSharp.UvConnectCb cb)
    {
        var __arg0 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg1 = handle is null ? IntPtr.Zero : handle.__Instance;
        var __arg5 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvPipeConnect2(__arg0, __arg1, name, namelen, flags, __arg5);
        return ___ret;
    }

    public static int UvPipeGetsockname(global::LibuvSharp.UvPipeS handle, sbyte* buffer, ref ulong size)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        fixed (ulong* __size2 = &size)
        {
            var __arg2 = __size2;
            var ___ret = __Internal.UvPipeGetsockname(__arg0, buffer, __arg2);
            return ___ret;
        }
    }

    public static int UvPipeGetpeername(global::LibuvSharp.UvPipeS handle, sbyte* buffer, ref ulong size)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        fixed (ulong* __size2 = &size)
        {
            var __arg2 = __size2;
            var ___ret = __Internal.UvPipeGetpeername(__arg0, buffer, __arg2);
            return ___ret;
        }
    }

    public static void UvPipePendingInstances(global::LibuvSharp.UvPipeS handle, int count)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        __Internal.UvPipePendingInstances(__arg0, count);
    }

    public static int UvPipePendingCount(global::LibuvSharp.UvPipeS handle)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvPipePendingCount(__arg0);
        return ___ret;
    }

    public static global::LibuvSharp.UvHandleType UvPipePendingType(global::LibuvSharp.UvPipeS handle)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvPipePendingType(__arg0);
        return ___ret;
    }

    public static int UvPipeChmod(global::LibuvSharp.UvPipeS handle, int flags)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvPipeChmod(__arg0, flags);
        return ___ret;
    }

    public static int UvPollInit(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvPollS handle, int fd)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvPollInit(__arg0, __arg1, fd);
        return ___ret;
    }

    public static int UvPollInitSocket(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvPollS handle, ulong socket)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvPollInitSocket(__arg0, __arg1, socket);
        return ___ret;
    }

    public static int UvPollStart(global::LibuvSharp.UvPollS handle, int events, global::LibuvSharp.UvPollCb cb)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var __arg2 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvPollStart(__arg0, events, __arg2);
        return ___ret;
    }

    public static int UvPollStop(global::LibuvSharp.UvPollS handle)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvPollStop(__arg0);
        return ___ret;
    }

    public static int UvPrepareInit(global::LibuvSharp.UvLoopS _0, global::LibuvSharp.UvPrepareS prepare)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var __arg1 = prepare is null ? IntPtr.Zero : prepare.__Instance;
        var ___ret = __Internal.UvPrepareInit(__arg0, __arg1);
        return ___ret;
    }

    public static int UvPrepareStart(global::LibuvSharp.UvPrepareS prepare, global::LibuvSharp.UvPrepareCb cb)
    {
        var __arg0 = prepare is null ? IntPtr.Zero : prepare.__Instance;
        var __arg1 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvPrepareStart(__arg0, __arg1);
        return ___ret;
    }

    public static int UvPrepareStop(global::LibuvSharp.UvPrepareS prepare)
    {
        var __arg0 = prepare is null ? IntPtr.Zero : prepare.__Instance;
        var ___ret = __Internal.UvPrepareStop(__arg0);
        return ___ret;
    }

    public static int UvCheckInit(global::LibuvSharp.UvLoopS _0, global::LibuvSharp.UvCheckS check)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var __arg1 = check is null ? IntPtr.Zero : check.__Instance;
        var ___ret = __Internal.UvCheckInit(__arg0, __arg1);
        return ___ret;
    }

    public static int UvCheckStart(global::LibuvSharp.UvCheckS check, global::LibuvSharp.UvCheckCb cb)
    {
        var __arg0 = check is null ? IntPtr.Zero : check.__Instance;
        var __arg1 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvCheckStart(__arg0, __arg1);
        return ___ret;
    }

    public static int UvCheckStop(global::LibuvSharp.UvCheckS check)
    {
        var __arg0 = check is null ? IntPtr.Zero : check.__Instance;
        var ___ret = __Internal.UvCheckStop(__arg0);
        return ___ret;
    }

    public static int UvIdleInit(global::LibuvSharp.UvLoopS _0, global::LibuvSharp.UvIdleS idle)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var __arg1 = idle is null ? IntPtr.Zero : idle.__Instance;
        var ___ret = __Internal.UvIdleInit(__arg0, __arg1);
        return ___ret;
    }

    public static int UvIdleStart(global::LibuvSharp.UvIdleS idle, global::LibuvSharp.UvIdleCb cb)
    {
        var __arg0 = idle is null ? IntPtr.Zero : idle.__Instance;
        var __arg1 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvIdleStart(__arg0, __arg1);
        return ___ret;
    }

    public static int UvIdleStop(global::LibuvSharp.UvIdleS idle)
    {
        var __arg0 = idle is null ? IntPtr.Zero : idle.__Instance;
        var ___ret = __Internal.UvIdleStop(__arg0);
        return ___ret;
    }

    public static int UvAsyncInit(global::LibuvSharp.UvLoopS _0, global::LibuvSharp.UvAsyncS async, global::LibuvSharp.UvAsyncCb async_cb)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var __arg1 = async is null ? IntPtr.Zero : async.__Instance;
        var __arg2 = async_cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(async_cb);
        var ___ret = __Internal.UvAsyncInit(__arg0, __arg1, __arg2);
        return ___ret;
    }

    public static int UvAsyncSend(global::LibuvSharp.UvAsyncS async)
    {
        var __arg0 = async is null ? IntPtr.Zero : async.__Instance;
        var ___ret = __Internal.UvAsyncSend(__arg0);
        return ___ret;
    }

    public static int UvTimerInit(global::LibuvSharp.UvLoopS _0, global::LibuvSharp.UvTimerS handle)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var __arg1 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvTimerInit(__arg0, __arg1);
        return ___ret;
    }

    public static int UvTimerStart(global::LibuvSharp.UvTimerS handle, global::LibuvSharp.UvTimerCb cb, ulong timeout, ulong repeat)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var __arg1 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvTimerStart(__arg0, __arg1, timeout, repeat);
        return ___ret;
    }

    public static int UvTimerStop(global::LibuvSharp.UvTimerS handle)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvTimerStop(__arg0);
        return ___ret;
    }

    public static int UvTimerAgain(global::LibuvSharp.UvTimerS handle)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvTimerAgain(__arg0);
        return ___ret;
    }

    public static void UvTimerSetRepeat(global::LibuvSharp.UvTimerS handle, ulong repeat)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        __Internal.UvTimerSetRepeat(__arg0, repeat);
    }

    public static ulong UvTimerGetRepeat(global::LibuvSharp.UvTimerS handle)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvTimerGetRepeat(__arg0);
        return ___ret;
    }

    public static ulong UvTimerGetDueIn(global::LibuvSharp.UvTimerS handle)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvTimerGetDueIn(__arg0);
        return ___ret;
    }

    public static int UvSpawn(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvProcessS handle, global::LibuvSharp.UvProcessOptionsS options)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = handle is null ? IntPtr.Zero : handle.__Instance;
        var __arg2 = options is null ? IntPtr.Zero : options.__Instance;
        var ___ret = __Internal.UvSpawn(__arg0, __arg1, __arg2);
        return ___ret;
    }

    public static int UvProcessKill(global::LibuvSharp.UvProcessS _0, int signum)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var ___ret = __Internal.UvProcessKill(__arg0, signum);
        return ___ret;
    }

    public static int UvKill(int pid, int signum)
    {
        var ___ret = __Internal.UvKill(pid, signum);
        return ___ret;
    }

    public static int UvProcessGetPid(global::LibuvSharp.UvProcessS _0)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var ___ret = __Internal.UvProcessGetPid(__arg0);
        return ___ret;
    }

    public static int UvQueueWork(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvWorkS req, global::LibuvSharp.UvWorkCb work_cb, global::LibuvSharp.UvAfterWorkCb after_work_cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg2 = work_cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(work_cb);
        var __arg3 = after_work_cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(after_work_cb);
        var ___ret = __Internal.UvQueueWork(__arg0, __arg1, __arg2, __arg3);
        return ___ret;
    }

    public static int UvCancel(global::LibuvSharp.UvReqS req)
    {
        var __arg0 = req is null ? IntPtr.Zero : req.__Instance;
        var ___ret = __Internal.UvCancel(__arg0);
        return ___ret;
    }

    public static sbyte** UvSetupArgs(int argc, sbyte** argv)
    {
        var ___ret = __Internal.UvSetupArgs(argc, argv);
        return ___ret;
    }

    public static int UvGetProcessTitle(sbyte* buffer, ulong size)
    {
        var ___ret = __Internal.UvGetProcessTitle(buffer, size);
        return ___ret;
    }

    public static int UvSetProcessTitle(string title)
    {
        var ___ret = __Internal.UvSetProcessTitle(title);
        return ___ret;
    }

    public static int UvResidentSetMemory(ref ulong rss)
    {
        fixed (ulong* __rss0 = &rss)
        {
            var __arg0 = __rss0;
            var ___ret = __Internal.UvResidentSetMemory(__arg0);
            return ___ret;
        }
    }

    public static int UvUptime(ref double uptime)
    {
        fixed (double* __uptime0 = &uptime)
        {
            var __arg0 = __uptime0;
            var ___ret = __Internal.UvUptime(__arg0);
            return ___ret;
        }
    }

    public static IntPtr UvGetOsfhandle(int fd)
    {
        var ___ret = __Internal.UvGetOsfhandle(fd);
        return ___ret;
    }

    public static int UvOpenOsfhandle(IntPtr os_fd)
    {
        var ___ret = __Internal.UvOpenOsfhandle(os_fd);
        return ___ret;
    }

    public static int UvGetrusage(global::LibuvSharp.UvRusageT rusage)
    {
        var __arg0 = rusage is null ? IntPtr.Zero : rusage.__Instance;
        var ___ret = __Internal.UvGetrusage(__arg0);
        return ___ret;
    }

    public static int UvOsHomedir(sbyte* buffer, ref ulong size)
    {
        fixed (ulong* __size1 = &size)
        {
            var __arg1 = __size1;
            var ___ret = __Internal.UvOsHomedir(buffer, __arg1);
            return ___ret;
        }
    }

    public static int UvOsTmpdir(sbyte* buffer, ref ulong size)
    {
        fixed (ulong* __size1 = &size)
        {
            var __arg1 = __size1;
            var ___ret = __Internal.UvOsTmpdir(buffer, __arg1);
            return ___ret;
        }
    }

    public static int UvOsGetPasswd(global::LibuvSharp.UvPasswdS pwd)
    {
        var __arg0 = pwd is null ? IntPtr.Zero : pwd.__Instance;
        var ___ret = __Internal.UvOsGetPasswd(__arg0);
        return ___ret;
    }

    public static void UvOsFreePasswd(global::LibuvSharp.UvPasswdS pwd)
    {
        var __arg0 = pwd is null ? IntPtr.Zero : pwd.__Instance;
        __Internal.UvOsFreePasswd(__arg0);
    }

    public static int UvOsGetPasswd2(global::LibuvSharp.UvPasswdS pwd, byte uid)
    {
        var __arg0 = pwd is null ? IntPtr.Zero : pwd.__Instance;
        var ___ret = __Internal.UvOsGetPasswd2(__arg0, uid);
        return ___ret;
    }

    public static int UvOsGetGroup(global::LibuvSharp.UvGroupS grp, byte gid)
    {
        var __arg0 = grp is null ? IntPtr.Zero : grp.__Instance;
        var ___ret = __Internal.UvOsGetGroup(__arg0, gid);
        return ___ret;
    }

    public static void UvOsFreeGroup(global::LibuvSharp.UvGroupS grp)
    {
        var __arg0 = grp is null ? IntPtr.Zero : grp.__Instance;
        __Internal.UvOsFreeGroup(__arg0);
    }

    public static int UvOsGetpid()
    {
        var ___ret = __Internal.UvOsGetpid();
        return ___ret;
    }

    public static int UvOsGetppid()
    {
        var ___ret = __Internal.UvOsGetppid();
        return ___ret;
    }

    public static int UvOsGetpriority(int pid, ref int priority)
    {
        fixed (int* __priority1 = &priority)
        {
            var __arg1 = __priority1;
            var ___ret = __Internal.UvOsGetpriority(pid, __arg1);
            return ___ret;
        }
    }

    public static int UvOsSetpriority(int pid, int priority)
    {
        var ___ret = __Internal.UvOsSetpriority(pid, priority);
        return ___ret;
    }

    public static uint UvAvailableParallelism()
    {
        var ___ret = __Internal.UvAvailableParallelism();
        return ___ret;
    }

    public static int UvCpuInfo(global::LibuvSharp.UvCpuInfoS cpu_infos, ref int count)
    {
        var ____arg0 = cpu_infos is null ? IntPtr.Zero : cpu_infos.__Instance;
        var __arg0   = new IntPtr(&____arg0);
        fixed (int* __count1 = &count)
        {
            var __arg1 = __count1;
            var ___ret = __Internal.UvCpuInfo(__arg0, __arg1);
            return ___ret;
        }
    }

    public static void UvFreeCpuInfo(global::LibuvSharp.UvCpuInfoS cpu_infos, int count)
    {
        var __arg0 = cpu_infos is null ? IntPtr.Zero : cpu_infos.__Instance;
        __Internal.UvFreeCpuInfo(__arg0, count);
    }

    public static int UvCpumaskSize()
    {
        var ___ret = __Internal.UvCpumaskSize();
        return ___ret;
    }

    public static int UvInterfaceAddresses(global::LibuvSharp.UvInterfaceAddressS addresses, ref int count)
    {
        var ____arg0 = addresses is null ? IntPtr.Zero : addresses.__Instance;
        var __arg0   = new IntPtr(&____arg0);
        fixed (int* __count1 = &count)
        {
            var __arg1 = __count1;
            var ___ret = __Internal.UvInterfaceAddresses(__arg0, __arg1);
            return ___ret;
        }
    }

    public static void UvFreeInterfaceAddresses(global::LibuvSharp.UvInterfaceAddressS addresses, int count)
    {
        var __arg0 = addresses is null ? IntPtr.Zero : addresses.__Instance;
        __Internal.UvFreeInterfaceAddresses(__arg0, count);
    }

    public static int UvOsEnviron(global::LibuvSharp.UvEnvItemS envitems, ref int count)
    {
        var ____arg0 = envitems is null ? IntPtr.Zero : envitems.__Instance;
        var __arg0   = new IntPtr(&____arg0);
        fixed (int* __count1 = &count)
        {
            var __arg1 = __count1;
            var ___ret = __Internal.UvOsEnviron(__arg0, __arg1);
            return ___ret;
        }
    }

    public static void UvOsFreeEnviron(global::LibuvSharp.UvEnvItemS envitems, int count)
    {
        var __arg0 = envitems is null ? IntPtr.Zero : envitems.__Instance;
        __Internal.UvOsFreeEnviron(__arg0, count);
    }

    public static int UvOsGetenv(string name, sbyte* buffer, ref ulong size)
    {
        fixed (ulong* __size2 = &size)
        {
            var __arg2 = __size2;
            var ___ret = __Internal.UvOsGetenv(name, buffer, __arg2);
            return ___ret;
        }
    }

    public static int UvOsSetenv(string name, string value)
    {
        var ___ret = __Internal.UvOsSetenv(name, value);
        return ___ret;
    }

    public static int UvOsUnsetenv(string name)
    {
        var ___ret = __Internal.UvOsUnsetenv(name);
        return ___ret;
    }

    public static int UvOsGethostname(sbyte* buffer, ref ulong size)
    {
        fixed (ulong* __size1 = &size)
        {
            var __arg1 = __size1;
            var ___ret = __Internal.UvOsGethostname(buffer, __arg1);
            return ___ret;
        }
    }

    public static int UvOsUname(global::LibuvSharp.UvUtsnameS buffer)
    {
        var __arg0 = buffer is null ? IntPtr.Zero : buffer.__Instance;
        var ___ret = __Internal.UvOsUname(__arg0);
        return ___ret;
    }

    public static int UvMetricsInfo(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvMetricsS metrics)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = metrics is null ? IntPtr.Zero : metrics.__Instance;
        var ___ret = __Internal.UvMetricsInfo(__arg0, __arg1);
        return ___ret;
    }

    public static ulong UvMetricsIdleTime(global::LibuvSharp.UvLoopS loop)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var ___ret = __Internal.UvMetricsIdleTime(__arg0);
        return ___ret;
    }

    public static global::LibuvSharp.UvFsType UvFsGetType(global::LibuvSharp.UvFsS _0)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var ___ret = __Internal.UvFsGetType(__arg0);
        return ___ret;
    }

    public static long UvFsGetResult(global::LibuvSharp.UvFsS _0)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var ___ret = __Internal.UvFsGetResult(__arg0);
        return ___ret;
    }

    public static int UvFsGetSystemError(global::LibuvSharp.UvFsS _0)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var ___ret = __Internal.UvFsGetSystemError(__arg0);
        return ___ret;
    }

    public static IntPtr UvFsGetPtr(global::LibuvSharp.UvFsS _0)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var ___ret = __Internal.UvFsGetPtr(__arg0);
        return ___ret;
    }

    public static string UvFsGetPath(global::LibuvSharp.UvFsS _0)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var ___ret = __Internal.UvFsGetPath(__arg0);
        return CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ___ret);
    }

    public static global::LibuvSharp.UvStatT UvFsGetStatbuf(global::LibuvSharp.UvFsS _0)
    {
        var __arg0    = _0 is null ? IntPtr.Zero : _0.__Instance;
        var ___ret    = __Internal.UvFsGetStatbuf(__arg0);
        var __result0 = global::LibuvSharp.UvStatT.__GetOrCreateInstance(___ret, false);
        return __result0;
    }

    public static void UvFsReqCleanup(global::LibuvSharp.UvFsS req)
    {
        var __arg0 = req is null ? IntPtr.Zero : req.__Instance;
        __Internal.UvFsReqCleanup(__arg0);
    }

    public static int UvFsClose(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, int file, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg3 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsClose(__arg0, __arg1, file, __arg3);
        return ___ret;
    }

    public static int UvFsOpen(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string path, int flags, int mode, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg5 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsOpen(__arg0, __arg1, path, flags, mode, __arg5);
        return ___ret;
    }

    public static int UvFsRead(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, int file, global::LibuvSharp.UvBufT[] bufs, uint nbufs, long offset, global::LibuvSharp.UvFsCb cb)
    {
        var                                    __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var                                    __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        global::LibuvSharp.UvBufT.__Internal[] __bufs;
        if (bufs == null)
            __bufs = null;
        else
        {
            __bufs = new global::LibuvSharp.UvBufT.__Internal[bufs.Length];
            for (var i = 0; i < __bufs.Length; i++)
            {
                var __element = bufs[i];
                __bufs[i] = __element is null ? new global::LibuvSharp.UvBufT.__Internal() : *(global::LibuvSharp.UvBufT.__Internal*) __element.__Instance;
            }
        }
        var __arg3 = __bufs;
        var __arg6 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsRead(__arg0, __arg1, file, __arg3, nbufs, offset, __arg6);
        return ___ret;
    }

    public static int UvFsUnlink(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string path, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg3 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsUnlink(__arg0, __arg1, path, __arg3);
        return ___ret;
    }

    public static int UvFsWrite(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, int file, global::LibuvSharp.UvBufT[] bufs, uint nbufs, long offset, global::LibuvSharp.UvFsCb cb)
    {
        var                                    __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var                                    __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        global::LibuvSharp.UvBufT.__Internal[] __bufs;
        if (bufs == null)
            __bufs = null;
        else
        {
            __bufs = new global::LibuvSharp.UvBufT.__Internal[bufs.Length];
            for (var i = 0; i < __bufs.Length; i++)
            {
                var __element = bufs[i];
                __bufs[i] = __element is null ? new global::LibuvSharp.UvBufT.__Internal() : *(global::LibuvSharp.UvBufT.__Internal*) __element.__Instance;
            }
        }
        var __arg3 = __bufs;
        var __arg6 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsWrite(__arg0, __arg1, file, __arg3, nbufs, offset, __arg6);
        return ___ret;
    }

    public static int UvFsCopyfile(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string path, string new_path, int flags, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg5 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsCopyfile(__arg0, __arg1, path, new_path, flags, __arg5);
        return ___ret;
    }

    public static int UvFsMkdir(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string path, int mode, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg4 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsMkdir(__arg0, __arg1, path, mode, __arg4);
        return ___ret;
    }

    public static int UvFsMkdtemp(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string tpl, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg3 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsMkdtemp(__arg0, __arg1, tpl, __arg3);
        return ___ret;
    }

    public static int UvFsMkstemp(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string tpl, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg3 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsMkstemp(__arg0, __arg1, tpl, __arg3);
        return ___ret;
    }

    public static int UvFsRmdir(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string path, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg3 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsRmdir(__arg0, __arg1, path, __arg3);
        return ___ret;
    }

    public static int UvFsScandir(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string path, int flags, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg4 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsScandir(__arg0, __arg1, path, flags, __arg4);
        return ___ret;
    }

    public static int UvFsScandirNext(global::LibuvSharp.UvFsS req, global::LibuvSharp.uv_dirent_s ent)
    {
        var __arg0 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg1 = ent is null ? IntPtr.Zero : ent.__Instance;
        var ___ret = __Internal.UvFsScandirNext(__arg0, __arg1);
        return ___ret;
    }

    public static int UvFsOpendir(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string path, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg3 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsOpendir(__arg0, __arg1, path, __arg3);
        return ___ret;
    }

    public static int UvFsReaddir(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, global::LibuvSharp.UvDirS dir, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg2 = dir is null ? IntPtr.Zero : dir.__Instance;
        var __arg3 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsReaddir(__arg0, __arg1, __arg2, __arg3);
        return ___ret;
    }

    public static int UvFsClosedir(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, global::LibuvSharp.UvDirS dir, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg2 = dir is null ? IntPtr.Zero : dir.__Instance;
        var __arg3 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsClosedir(__arg0, __arg1, __arg2, __arg3);
        return ___ret;
    }

    public static int UvFsStat(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string path, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg3 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsStat(__arg0, __arg1, path, __arg3);
        return ___ret;
    }

    public static int UvFsFstat(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, int file, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg3 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsFstat(__arg0, __arg1, file, __arg3);
        return ___ret;
    }

    public static int UvFsRename(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string path, string new_path, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg4 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsRename(__arg0, __arg1, path, new_path, __arg4);
        return ___ret;
    }

    public static int UvFsFsync(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, int file, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg3 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsFsync(__arg0, __arg1, file, __arg3);
        return ___ret;
    }

    public static int UvFsFdatasync(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, int file, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg3 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsFdatasync(__arg0, __arg1, file, __arg3);
        return ___ret;
    }

    public static int UvFsFtruncate(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, int file, long offset, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg4 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsFtruncate(__arg0, __arg1, file, offset, __arg4);
        return ___ret;
    }

    public static int UvFsSendfile(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, int out_fd, int in_fd, long in_offset, ulong length, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg6 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsSendfile(__arg0, __arg1, out_fd, in_fd, in_offset, length, __arg6);
        return ___ret;
    }

    public static int UvFsAccess(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string path, int mode, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg4 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsAccess(__arg0, __arg1, path, mode, __arg4);
        return ___ret;
    }

    public static int UvFsChmod(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string path, int mode, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg4 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsChmod(__arg0, __arg1, path, mode, __arg4);
        return ___ret;
    }

    public static int UvFsUtime(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string path, double atime, double mtime, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg5 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsUtime(__arg0, __arg1, path, atime, mtime, __arg5);
        return ___ret;
    }

    public static int UvFsFutime(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, int file, double atime, double mtime, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg5 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsFutime(__arg0, __arg1, file, atime, mtime, __arg5);
        return ___ret;
    }

    public static int UvFsLutime(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string path, double atime, double mtime, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg5 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsLutime(__arg0, __arg1, path, atime, mtime, __arg5);
        return ___ret;
    }

    public static int UvFsLstat(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string path, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg3 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsLstat(__arg0, __arg1, path, __arg3);
        return ___ret;
    }

    public static int UvFsLink(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string path, string new_path, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg4 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsLink(__arg0, __arg1, path, new_path, __arg4);
        return ___ret;
    }

    public static int UvFsSymlink(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string path, string new_path, int flags, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg5 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsSymlink(__arg0, __arg1, path, new_path, flags, __arg5);
        return ___ret;
    }

    public static int UvFsReadlink(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string path, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg3 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsReadlink(__arg0, __arg1, path, __arg3);
        return ___ret;
    }

    public static int UvFsRealpath(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string path, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg3 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsRealpath(__arg0, __arg1, path, __arg3);
        return ___ret;
    }

    public static int UvFsFchmod(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, int file, int mode, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg4 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsFchmod(__arg0, __arg1, file, mode, __arg4);
        return ___ret;
    }

    public static int UvFsChown(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string path, byte uid, byte gid, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg5 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsChown(__arg0, __arg1, path, uid, gid, __arg5);
        return ___ret;
    }

    public static int UvFsFchown(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, int file, byte uid, byte gid, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg5 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsFchown(__arg0, __arg1, file, uid, gid, __arg5);
        return ___ret;
    }

    public static int UvFsLchown(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string path, byte uid, byte gid, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg5 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsLchown(__arg0, __arg1, path, uid, gid, __arg5);
        return ___ret;
    }

    public static int UvFsStatfs(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsS req, string path, global::LibuvSharp.UvFsCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg3 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsStatfs(__arg0, __arg1, path, __arg3);
        return ___ret;
    }

    public static int UvFsPollInit(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsPollS handle)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvFsPollInit(__arg0, __arg1);
        return ___ret;
    }

    public static int UvFsPollStart(global::LibuvSharp.UvFsPollS handle, global::LibuvSharp.UvFsPollCb poll_cb, string path, uint interval)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var __arg1 = poll_cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(poll_cb);
        var ___ret = __Internal.UvFsPollStart(__arg0, __arg1, path, interval);
        return ___ret;
    }

    public static int UvFsPollStop(global::LibuvSharp.UvFsPollS handle)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvFsPollStop(__arg0);
        return ___ret;
    }

    public static int UvFsPollGetpath(global::LibuvSharp.UvFsPollS handle, sbyte* buffer, ref ulong size)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        fixed (ulong* __size2 = &size)
        {
            var __arg2 = __size2;
            var ___ret = __Internal.UvFsPollGetpath(__arg0, buffer, __arg2);
            return ___ret;
        }
    }

    public static int UvSignalInit(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvSignalS handle)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvSignalInit(__arg0, __arg1);
        return ___ret;
    }

    public static int UvSignalStart(global::LibuvSharp.UvSignalS handle, global::LibuvSharp.UvSignalCb signal_cb, int signum)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var __arg1 = signal_cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(signal_cb);
        var ___ret = __Internal.UvSignalStart(__arg0, __arg1, signum);
        return ___ret;
    }

    public static int UvSignalStartOneshot(global::LibuvSharp.UvSignalS handle, global::LibuvSharp.UvSignalCb signal_cb, int signum)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var __arg1 = signal_cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(signal_cb);
        var ___ret = __Internal.UvSignalStartOneshot(__arg0, __arg1, signum);
        return ___ret;
    }

    public static int UvSignalStop(global::LibuvSharp.UvSignalS handle)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvSignalStop(__arg0);
        return ___ret;
    }

    public static void UvLoadavg(double[] avg)
    {
        if (avg == null || avg.Length != 3)
            throw new ArgumentOutOfRangeException("avg", "The dimensions of the provided array don't match the required size.");
        __Internal.UvLoadavg(avg);
    }

    public static int UvFsEventInit(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvFsEventS handle)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvFsEventInit(__arg0, __arg1);
        return ___ret;
    }

    public static int UvFsEventStart(global::LibuvSharp.UvFsEventS handle, global::LibuvSharp.UvFsEventCb cb, string path, uint flags)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var __arg1 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvFsEventStart(__arg0, __arg1, path, flags);
        return ___ret;
    }

    public static int UvFsEventStop(global::LibuvSharp.UvFsEventS handle)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        var ___ret = __Internal.UvFsEventStop(__arg0);
        return ___ret;
    }

    public static int UvFsEventGetpath(global::LibuvSharp.UvFsEventS handle, sbyte* buffer, ref ulong size)
    {
        var __arg0 = handle is null ? IntPtr.Zero : handle.__Instance;
        fixed (ulong* __size2 = &size)
        {
            var __arg2 = __size2;
            var ___ret = __Internal.UvFsEventGetpath(__arg0, buffer, __arg2);
            return ___ret;
        }
    }

    public static int UvInetNtop(int af, IntPtr src, sbyte* dst, ulong size)
    {
        var ___ret = __Internal.UvInetNtop(af, src, dst, size);
        return ___ret;
    }

    public static int UvInetPton(int af, string src, IntPtr dst)
    {
        var ___ret = __Internal.UvInetPton(af, src, dst);
        return ___ret;
    }

    public static int UvRandom(global::LibuvSharp.UvLoopS loop, global::LibuvSharp.UvRandomS req, IntPtr buf, ulong buflen, uint flags, global::LibuvSharp.UvRandomCb cb)
    {
        var __arg0 = loop is null ? IntPtr.Zero : loop.__Instance;
        var __arg1 = req is null ? IntPtr.Zero : req.__Instance;
        var __arg5 = cb == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(cb);
        var ___ret = __Internal.UvRandom(__arg0, __arg1, buf, buflen, flags, __arg5);
        return ___ret;
    }

    public static int UvIfIndextoname(uint ifindex, sbyte* buffer, ref ulong size)
    {
        fixed (ulong* __size2 = &size)
        {
            var __arg2 = __size2;
            var ___ret = __Internal.UvIfIndextoname(ifindex, buffer, __arg2);
            return ___ret;
        }
    }

    public static int UvIfIndextoiid(uint ifindex, sbyte* buffer, ref ulong size)
    {
        fixed (ulong* __size2 = &size)
        {
            var __arg2 = __size2;
            var ___ret = __Internal.UvIfIndextoiid(ifindex, buffer, __arg2);
            return ___ret;
        }
    }

    public static int UvExepath(sbyte* buffer, ref ulong size)
    {
        fixed (ulong* __size1 = &size)
        {
            var __arg1 = __size1;
            var ___ret = __Internal.UvExepath(buffer, __arg1);
            return ___ret;
        }
    }

    public static int UvCwd(sbyte* buffer, ref ulong size)
    {
        fixed (ulong* __size1 = &size)
        {
            var __arg1 = __size1;
            var ___ret = __Internal.UvCwd(buffer, __arg1);
            return ___ret;
        }
    }

    public static int UvChdir(string dir)
    {
        var ___ret = __Internal.UvChdir(dir);
        return ___ret;
    }

    public static ulong UvGetFreeMemory()
    {
        var ___ret = __Internal.UvGetFreeMemory();
        return ___ret;
    }

    public static ulong UvGetTotalMemory()
    {
        var ___ret = __Internal.UvGetTotalMemory();
        return ___ret;
    }

    public static ulong UvGetConstrainedMemory()
    {
        var ___ret = __Internal.UvGetConstrainedMemory();
        return ___ret;
    }

    public static ulong UvGetAvailableMemory()
    {
        var ___ret = __Internal.UvGetAvailableMemory();
        return ___ret;
    }

    public static int UvClockGettime(global::LibuvSharp.UvClockId clock_id, global::LibuvSharp.UvTimespec64T ts)
    {
        var __arg1 = ts is null ? IntPtr.Zero : ts.__Instance;
        var ___ret = __Internal.UvClockGettime(clock_id, __arg1);
        return ___ret;
    }

    public static ulong UvHrtime()
    {
        var ___ret = __Internal.UvHrtime();
        return ___ret;
    }

    public static void UvSleep(uint msec)
    {
        __Internal.UvSleep(msec);
    }

    public static void UvDisableStdioInheritance()
    {
        __Internal.UvDisableStdioInheritance();
    }

    public static int UvDlopen(string filename, global::LibuvSharp.UvLibT lib)
    {
        var __arg1 = lib is null ? IntPtr.Zero : lib.__Instance;
        var ___ret = __Internal.UvDlopen(filename, __arg1);
        return ___ret;
    }

    public static void UvDlclose(global::LibuvSharp.UvLibT lib)
    {
        var __arg0 = lib is null ? IntPtr.Zero : lib.__Instance;
        __Internal.UvDlclose(__arg0);
    }

    public static int UvDlsym(global::LibuvSharp.UvLibT lib, string name, IntPtr* ptr)
    {
        var __arg0 = lib is null ? IntPtr.Zero : lib.__Instance;
        var ___ret = __Internal.UvDlsym(__arg0, name, ptr);
        return ___ret;
    }

    public static string UvDlerror(global::LibuvSharp.UvLibT lib)
    {
        var __arg0 = lib is null ? IntPtr.Zero : lib.__Instance;
        var ___ret = __Internal.UvDlerror(__arg0);
        return CppSharp.Runtime.MarshalUtil.GetString(global::System.Text.Encoding.UTF8, ___ret);
    }

    public static int UvRwlockInit(global::LibuvSharp.UvRwlockT rwlock)
    {
        var __arg0 = rwlock is null ? IntPtr.Zero : rwlock.__Instance;
        var ___ret = __Internal.UvRwlockInit(__arg0);
        return ___ret;
    }

    public static void UvRwlockDestroy(global::LibuvSharp.UvRwlockT rwlock)
    {
        var __arg0 = rwlock is null ? IntPtr.Zero : rwlock.__Instance;
        __Internal.UvRwlockDestroy(__arg0);
    }

    public static void UvRwlockRdlock(global::LibuvSharp.UvRwlockT rwlock)
    {
        var __arg0 = rwlock is null ? IntPtr.Zero : rwlock.__Instance;
        __Internal.UvRwlockRdlock(__arg0);
    }

    public static int UvRwlockTryrdlock(global::LibuvSharp.UvRwlockT rwlock)
    {
        var __arg0 = rwlock is null ? IntPtr.Zero : rwlock.__Instance;
        var ___ret = __Internal.UvRwlockTryrdlock(__arg0);
        return ___ret;
    }

    public static void UvRwlockRdunlock(global::LibuvSharp.UvRwlockT rwlock)
    {
        var __arg0 = rwlock is null ? IntPtr.Zero : rwlock.__Instance;
        __Internal.UvRwlockRdunlock(__arg0);
    }

    public static void UvRwlockWrlock(global::LibuvSharp.UvRwlockT rwlock)
    {
        var __arg0 = rwlock is null ? IntPtr.Zero : rwlock.__Instance;
        __Internal.UvRwlockWrlock(__arg0);
    }

    public static int UvRwlockTrywrlock(global::LibuvSharp.UvRwlockT rwlock)
    {
        var __arg0 = rwlock is null ? IntPtr.Zero : rwlock.__Instance;
        var ___ret = __Internal.UvRwlockTrywrlock(__arg0);
        return ___ret;
    }

    public static void UvRwlockWrunlock(global::LibuvSharp.UvRwlockT rwlock)
    {
        var __arg0 = rwlock is null ? IntPtr.Zero : rwlock.__Instance;
        __Internal.UvRwlockWrunlock(__arg0);
    }

    public static int UvSemInit(IntPtr* sem, uint value)
    {
        var ___ret = __Internal.UvSemInit(sem, value);
        return ___ret;
    }

    public static void UvSemDestroy(IntPtr* sem)
    {
        __Internal.UvSemDestroy(sem);
    }

    public static void UvSemPost(IntPtr* sem)
    {
        __Internal.UvSemPost(sem);
    }

    public static void UvSemWait(IntPtr* sem)
    {
        __Internal.UvSemWait(sem);
    }

    public static int UvSemTrywait(IntPtr* sem)
    {
        var ___ret = __Internal.UvSemTrywait(sem);
        return ___ret;
    }

    public static int UvCondInit(global::LibuvSharp.UvCondT cond)
    {
        var ____arg0 = cond.__Instance;
        var __arg0   = new IntPtr(&____arg0);
        var ___ret   = __Internal.UvCondInit(__arg0);
        return ___ret;
    }

    public static void UvCondDestroy(global::LibuvSharp.UvCondT cond)
    {
        var ____arg0 = cond.__Instance;
        var __arg0   = new IntPtr(&____arg0);
        __Internal.UvCondDestroy(__arg0);
    }

    public static void UvCondSignal(global::LibuvSharp.UvCondT cond)
    {
        var ____arg0 = cond.__Instance;
        var __arg0   = new IntPtr(&____arg0);
        __Internal.UvCondSignal(__arg0);
    }

    public static void UvCondBroadcast(global::LibuvSharp.UvCondT cond)
    {
        var ____arg0 = cond.__Instance;
        var __arg0   = new IntPtr(&____arg0);
        __Internal.UvCondBroadcast(__arg0);
    }

    public static int UvBarrierInit(global::LibuvSharp.UvBarrierT barrier, uint count)
    {
        var __arg0 = barrier is null ? IntPtr.Zero : barrier.__Instance;
        var ___ret = __Internal.UvBarrierInit(__arg0, count);
        return ___ret;
    }

    public static void UvBarrierDestroy(global::LibuvSharp.UvBarrierT barrier)
    {
        var __arg0 = barrier is null ? IntPtr.Zero : barrier.__Instance;
        __Internal.UvBarrierDestroy(__arg0);
    }

    public static int UvBarrierWait(global::LibuvSharp.UvBarrierT barrier)
    {
        var __arg0 = barrier is null ? IntPtr.Zero : barrier.__Instance;
        var ___ret = __Internal.UvBarrierWait(__arg0);
        return ___ret;
    }

    public static void UvOnce(global::LibuvSharp.UvOnceS guard, global::LibuvSharp.Delegates.Action_ callback)
    {
        var __arg0 = guard is null ? IntPtr.Zero : guard.__Instance;
        var __arg1 = callback == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback);
        __Internal.UvOnce(__arg0, __arg1);
    }

    public static int UvKeyCreate(global::LibuvSharp.UvKeyT key)
    {
        var __arg0 = key is null ? IntPtr.Zero : key.__Instance;
        var ___ret = __Internal.UvKeyCreate(__arg0);
        return ___ret;
    }

    public static void UvKeyDelete(global::LibuvSharp.UvKeyT key)
    {
        var __arg0 = key is null ? IntPtr.Zero : key.__Instance;
        __Internal.UvKeyDelete(__arg0);
    }

    public static IntPtr UvKeyGet(global::LibuvSharp.UvKeyT key)
    {
        var __arg0 = key is null ? IntPtr.Zero : key.__Instance;
        var ___ret = __Internal.UvKeyGet(__arg0);
        return ___ret;
    }

    public static void UvKeySet(global::LibuvSharp.UvKeyT key, IntPtr value)
    {
        var __arg0 = key is null ? IntPtr.Zero : key.__Instance;
        __Internal.UvKeySet(__arg0, value);
    }

    public static int UvGettimeofday(global::LibuvSharp.UvTimeval64T tv)
    {
        var __arg0 = tv is null ? IntPtr.Zero : tv.__Instance;
        var ___ret = __Internal.UvGettimeofday(__arg0);
        return ___ret;
    }

    public static int UvThreadCreate(IntPtr* tid, global::LibuvSharp.UvThreadCb entry, IntPtr arg)
    {
        var __arg1 = entry == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(entry);
        var ___ret = __Internal.UvThreadCreate(tid, __arg1, arg);
        return ___ret;
    }

    public static int UvThreadCreateEx(IntPtr* tid, global::LibuvSharp.UvThreadOptionsS @params, global::LibuvSharp.UvThreadCb entry, IntPtr arg)
    {
        var __arg1 = @params is null ? IntPtr.Zero : @params.__Instance;
        var __arg2 = entry == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(entry);
        var ___ret = __Internal.UvThreadCreateEx(tid, __arg1, __arg2, arg);
        return ___ret;
    }

    public static int UvThreadSetaffinity(IntPtr* tid, sbyte* cpumask, sbyte* oldmask, ulong mask_size)
    {
        var ___ret = __Internal.UvThreadSetaffinity(tid, cpumask, oldmask, mask_size);
        return ___ret;
    }

    public static int UvThreadGetaffinity(IntPtr* tid, sbyte* cpumask, ulong mask_size)
    {
        var ___ret = __Internal.UvThreadGetaffinity(tid, cpumask, mask_size);
        return ___ret;
    }

    public static int UvThreadGetcpu()
    {
        var ___ret = __Internal.UvThreadGetcpu();
        return ___ret;
    }

    public static IntPtr UvThreadSelf()
    {
        var ___ret = __Internal.UvThreadSelf();
        return ___ret;
    }

    public static int UvThreadJoin(IntPtr* tid)
    {
        var ___ret = __Internal.UvThreadJoin(tid);
        return ___ret;
    }

    public static int UvThreadEqual(IntPtr* t1, IntPtr* t2)
    {
        var ___ret = __Internal.UvThreadEqual(t1, t2);
        return ___ret;
    }

    public static IntPtr UvLoopGetData(global::LibuvSharp.UvLoopS _0)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        var ___ret = __Internal.UvLoopGetData(__arg0);
        return ___ret;
    }

    public static void UvLoopSetData(global::LibuvSharp.UvLoopS _0, IntPtr data)
    {
        var __arg0 = _0 is null ? IntPtr.Zero : _0.__Instance;
        __Internal.UvLoopSetData(__arg0, data);
    }
}