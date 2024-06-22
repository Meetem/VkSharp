using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkMemoryMapFlags : uint
    {
        VK_MEMORY_MAP_PLACED_BIT_EXT = (uint)(0x00000001U),
        VK_MEMORY_MAP_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
