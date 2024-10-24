﻿using Antelcat.LibuvSharp.Internal;

namespace Antelcat.LibuvSharp;

public class UVDirectoryEntity
{
    internal unsafe UVDirectoryEntity(uv_dirent_t entity)
    {
        Name = new string(entity.name);
        Type = entity.type;
    }

    public string                Name { get; set; }
    public UVDirectoryEntityType Type { get; set; }
}
