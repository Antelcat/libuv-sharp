﻿namespace Antelcat.LibuvSharp;

public interface IFileDescriptor
{
    void Open(IntPtr socket);

    IntPtr FileDescriptor { get; }
}
