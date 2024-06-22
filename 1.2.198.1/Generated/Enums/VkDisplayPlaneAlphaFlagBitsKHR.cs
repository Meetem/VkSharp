using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkDisplayPlaneAlphaFlagBitsKHR : uint
    {
        VK_DISPLAY_PLANE_ALPHA_OPAQUE_BIT_KHR = (uint)(0x00000001U),
        VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR = (uint)(0x00000002U),
        VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR = (uint)(0x00000004U),
        VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_PREMULTIPLIED_BIT_KHR = (uint)(0x00000008U),
        VK_DISPLAY_PLANE_ALPHA_FLAG_BITS_MAX_ENUM_KHR = (uint)(0x7FFFFFFFU),
    }
}
