using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkImageAspectFlags : uint
    {
        VK_IMAGE_ASPECT_COLOR_BIT = (uint)(0x00000001U),
        VK_IMAGE_ASPECT_DEPTH_BIT = (uint)(0x00000002U),
        VK_IMAGE_ASPECT_STENCIL_BIT = (uint)(0x00000004U),
        VK_IMAGE_ASPECT_METADATA_BIT = (uint)(0x00000008U),
        VK_IMAGE_ASPECT_PLANE_0_BIT = (uint)(0x00000010U),
        VK_IMAGE_ASPECT_PLANE_1_BIT = (uint)(0x00000020U),
        VK_IMAGE_ASPECT_PLANE_2_BIT = (uint)(0x00000040U),
        VK_IMAGE_ASPECT_MEMORY_PLANE_0_BIT_EXT = (uint)(0x00000080U),
        VK_IMAGE_ASPECT_MEMORY_PLANE_1_BIT_EXT = (uint)(0x00000100U),
        VK_IMAGE_ASPECT_MEMORY_PLANE_2_BIT_EXT = (uint)(0x00000200U),
        VK_IMAGE_ASPECT_MEMORY_PLANE_3_BIT_EXT = (uint)(0x00000400U),
        VK_IMAGE_ASPECT_PLANE_0_BIT_KHR = (uint)(0x00000010U),
        VK_IMAGE_ASPECT_PLANE_1_BIT_KHR = (uint)(0x00000020U),
        VK_IMAGE_ASPECT_PLANE_2_BIT_KHR = (uint)(0x00000040U),
        VK_IMAGE_ASPECT_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
