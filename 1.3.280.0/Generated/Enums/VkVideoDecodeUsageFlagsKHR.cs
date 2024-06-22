using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkVideoDecodeUsageFlagsKHR : uint
    {
        VK_VIDEO_DECODE_USAGE_DEFAULT_KHR = (uint)(0x00000000U),
        VK_VIDEO_DECODE_USAGE_TRANSCODING_BIT_KHR = (uint)(0x00000001U),
        VK_VIDEO_DECODE_USAGE_OFFLINE_BIT_KHR = (uint)(0x00000002U),
        VK_VIDEO_DECODE_USAGE_STREAMING_BIT_KHR = (uint)(0x00000004U),
        VK_VIDEO_DECODE_USAGE_FLAG_BITS_MAX_ENUM_KHR = (uint)(0x7FFFFFFFU),
    }
}
