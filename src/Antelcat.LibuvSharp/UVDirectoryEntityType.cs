﻿namespace Antelcat.LibuvSharp;

public enum UVDirectoryEntityType : uint
{
    Unknown,
    File,
    Directory,
    Link,
    FIFO,
    Socket,
    Char,
    Block
}
