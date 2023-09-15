﻿namespace LibuvSharp;

[Flags]
public enum TagREGCLS
{
    REGCLS_SINGLEUSE      = 0,
    REGCLS_MULTIPLEUSE    = 1,
    REGCLS_MULTI_SEPARATE = 2,
    REGCLS_SUSPENDED      = 4,
    REGCLS_SURROGATE      = 8
}