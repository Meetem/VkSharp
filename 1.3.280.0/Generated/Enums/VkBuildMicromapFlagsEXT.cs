using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkBuildMicromapFlagsEXT : uint
    {
        VK_BUILD_MICROMAP_PREFER_FAST_TRACE_BIT_EXT = (uint)(0x00000001U),
        VK_BUILD_MICROMAP_PREFER_FAST_BUILD_BIT_EXT = (uint)(0x00000002U),
        VK_BUILD_MICROMAP_ALLOW_COMPACTION_BIT_EXT = (uint)(0x00000004U),
        VK_BUILD_MICROMAP_FLAG_BITS_MAX_ENUM_EXT = (uint)(0x7FFFFFFFU),
    }
}
