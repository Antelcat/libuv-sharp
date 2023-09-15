﻿namespace LibuvSharp;

[Flags]
public enum TagCOWAIT_FLAGS
{
    COWAIT_DEFAULT                  = 0,
    COWAIT_WAITALL                  = 1,
    COWAIT_ALERTABLE                = 2,
    COWAIT_INPUTAVAILABLE           = 4,
    COWAIT_DISPATCH_CALLS           = 8,
    COWAIT_DISPATCH_WINDOW_MESSAGES = 16
}