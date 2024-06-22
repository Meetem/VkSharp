using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkVideoComponentBitDepthFlagsKHR : uint
    {
        VK_VIDEO_COMPONENT_BIT_DEPTH_INVALID_KHR = (uint)(0x00000000U),
        VK_VIDEO_COMPONENT_BIT_DEPTH_8_BIT_KHR = (uint)(0x00000001U),
        VK_VIDEO_COMPONENT_BIT_DEPTH_10_BIT_KHR = (uint)(0x00000004U),
        VK_VIDEO_COMPONENT_BIT_DEPTH_12_BIT_KHR = (uint)(0x00000010U),
        VK_VIDEO_COMPONENT_BIT_DEPTH_FLAG_BITS_MAX_ENUM_KHR = (uint)(0x7FFFFFFFU),
    }
}
