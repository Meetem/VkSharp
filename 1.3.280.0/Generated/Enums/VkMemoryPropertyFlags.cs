using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkMemoryPropertyFlags : uint
    {
        VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT = (uint)(0x00000001U),
        VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT = (uint)(0x00000002U),
        VK_MEMORY_PROPERTY_HOST_COHERENT_BIT = (uint)(0x00000004U),
        VK_MEMORY_PROPERTY_HOST_CACHED_BIT = (uint)(0x00000008U),
        VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT = (uint)(0x00000010U),
        VK_MEMORY_PROPERTY_PROTECTED_BIT = (uint)(0x00000020U),
        VK_MEMORY_PROPERTY_DEVICE_COHERENT_BIT_AMD = (uint)(0x00000040U),
        VK_MEMORY_PROPERTY_DEVICE_UNCACHED_BIT_AMD = (uint)(0x00000080U),
        VK_MEMORY_PROPERTY_RDMA_CAPABLE_BIT_NV = (uint)(0x00000100U),
        VK_MEMORY_PROPERTY_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
