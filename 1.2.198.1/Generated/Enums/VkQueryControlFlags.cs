using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkQueryControlFlags : uint
    {
        VK_QUERY_CONTROL_PRECISE_BIT = (uint)(0x00000001U),
        VK_QUERY_CONTROL_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
