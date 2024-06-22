using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkVideoEncodeRateControlModeFlagsKHR : uint
    {
        VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DEFAULT_KHR = (uint)(0x00000000U),
        VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DISABLED_BIT_KHR = (uint)(0x00000001U),
        VK_VIDEO_ENCODE_RATE_CONTROL_MODE_CBR_BIT_KHR = (uint)(0x00000002U),
        VK_VIDEO_ENCODE_RATE_CONTROL_MODE_VBR_BIT_KHR = (uint)(0x00000004U),
        VK_VIDEO_ENCODE_RATE_CONTROL_MODE_FLAG_BITS_MAX_ENUM_KHR = (uint)(0x7FFFFFFFU),
    }
}
