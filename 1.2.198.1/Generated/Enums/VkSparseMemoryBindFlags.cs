using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkSparseMemoryBindFlags : uint
    {
        VK_SPARSE_MEMORY_BIND_METADATA_BIT = (uint)(0x00000001U),
        VK_SPARSE_MEMORY_BIND_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
