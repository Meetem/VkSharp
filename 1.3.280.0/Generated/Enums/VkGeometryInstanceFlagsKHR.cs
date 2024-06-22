using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkGeometryInstanceFlagsKHR : uint
    {
        VK_GEOMETRY_INSTANCE_TRIANGLE_FACING_CULL_DISABLE_BIT_KHR = (uint)(0x00000001U),
        VK_GEOMETRY_INSTANCE_TRIANGLE_FLIP_FACING_BIT_KHR = (uint)(0x00000002U),
        VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_KHR = (uint)(0x00000004U),
        VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_KHR = (uint)(0x00000008U),
        VK_GEOMETRY_INSTANCE_FORCE_OPACITY_MICROMAP_2_STATE_EXT = (uint)(0x00000010U),
        VK_GEOMETRY_INSTANCE_DISABLE_OPACITY_MICROMAPS_EXT = (uint)(0x00000020U),
        VK_GEOMETRY_INSTANCE_TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_KHR = (uint)(0x00000002U),
        VK_GEOMETRY_INSTANCE_TRIANGLE_CULL_DISABLE_BIT_NV = (uint)(0x00000001U),
        VK_GEOMETRY_INSTANCE_TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_NV = (uint)(0x00000002U),
        VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_NV = (uint)(0x00000004U),
        VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_NV = (uint)(0x00000008U),
        VK_GEOMETRY_INSTANCE_FLAG_BITS_MAX_ENUM_KHR = (uint)(0x7FFFFFFFU),
    }
}
