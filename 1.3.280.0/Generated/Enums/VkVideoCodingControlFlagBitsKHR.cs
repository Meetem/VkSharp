using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkVideoCodingControlFlagBitsKHR : uint
    {
        VK_VIDEO_CODING_CONTROL_RESET_BIT_KHR = (uint)(0x00000001U),
        VK_VIDEO_CODING_CONTROL_ENCODE_RATE_CONTROL_BIT_KHR = (uint)(0x00000002U),
        VK_VIDEO_CODING_CONTROL_ENCODE_QUALITY_LEVEL_BIT_KHR = (uint)(0x00000004U),
        VK_VIDEO_CODING_CONTROL_FLAG_BITS_MAX_ENUM_KHR = (uint)(0x7FFFFFFFU),
    }
}
