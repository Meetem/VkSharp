using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkMemoryHeapFlagBits : uint
    {
        VK_MEMORY_HEAP_DEVICE_LOCAL_BIT = (uint)(0x00000001U),
        VK_MEMORY_HEAP_MULTI_INSTANCE_BIT = (uint)(0x00000002U),
        VK_MEMORY_HEAP_MULTI_INSTANCE_BIT_KHR = (uint)(0x00000002U),
        VK_MEMORY_HEAP_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
