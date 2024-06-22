using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkMemoryAllocateFlags : uint
    {
        VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT = (uint)(0x00000001U),
        VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT = (uint)(0x00000002U),
        VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT = (uint)(0x00000004U),
        VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT_KHR = (uint)(0x00000001U),
        VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT_KHR = (uint)(0x00000002U),
        VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR = (uint)(0x00000004U),
        VK_MEMORY_ALLOCATE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
