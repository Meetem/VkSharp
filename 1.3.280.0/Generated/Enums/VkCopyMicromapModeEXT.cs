using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkCopyMicromapModeEXT
    {
        VK_COPY_MICROMAP_MODE_CLONE_EXT = (int)(0),
        VK_COPY_MICROMAP_MODE_SERIALIZE_EXT = (int)(1),
        VK_COPY_MICROMAP_MODE_DESERIALIZE_EXT = (int)(2),
        VK_COPY_MICROMAP_MODE_COMPACT_EXT = (int)(3),
        VK_COPY_MICROMAP_MODE_MAX_ENUM_EXT = (int)(2147483647),
    }
}
