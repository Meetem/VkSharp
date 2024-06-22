using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkMemoryUnmapFlagsKHR : uint
    {
        VK_MEMORY_UNMAP_RESERVE_BIT_EXT = (uint)(0x00000001U),
        VK_MEMORY_UNMAP_FLAG_BITS_MAX_ENUM_KHR = (uint)(0x7FFFFFFFU),
    }
}
