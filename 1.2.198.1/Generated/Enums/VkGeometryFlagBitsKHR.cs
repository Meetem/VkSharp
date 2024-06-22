using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkGeometryFlagBitsKHR : uint
    {
        VK_GEOMETRY_OPAQUE_BIT_KHR = (uint)(0x00000001U),
        VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_KHR = (uint)(0x00000002U),
        VK_GEOMETRY_OPAQUE_BIT_NV = (uint)(0x00000001U),
        VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_NV = (uint)(0x00000002U),
        VK_GEOMETRY_FLAG_BITS_MAX_ENUM_KHR = (uint)(0x7FFFFFFFU),
    }
}
