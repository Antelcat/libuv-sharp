﻿namespace LibuvSharp;

public enum VIRTUAL_STORAGE_BEHAVIOR_CODE
{
    VirtualStorageBehaviorUndefined           = 0,
    VirtualStorageBehaviorCacheWriteThrough   = 1,
    VirtualStorageBehaviorCacheWriteBack      = 2,
    VirtualStorageBehaviorStopIoProcessing    = 3,
    VirtualStorageBehaviorRestartIoProcessing = 4
}