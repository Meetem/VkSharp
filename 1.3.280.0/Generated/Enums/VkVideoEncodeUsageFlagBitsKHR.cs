using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkVideoEncodeUsageFlagBitsKHR : uint
    {
        VK_VIDEO_ENCODE_USAGE_DEFAULT_KHR = (uint)(0x00000000U),
        VK_VIDEO_ENCODE_USAGE_TRANSCODING_BIT_KHR = (uint)(0x00000001U),
        VK_VIDEO_ENCODE_USAGE_STREAMING_BIT_KHR = (uint)(0x00000002U),
        VK_VIDEO_ENCODE_USAGE_RECORDING_BIT_KHR = (uint)(0x00000004U),
        VK_VIDEO_ENCODE_USAGE_CONFERENCING_BIT_KHR = (uint)(0x00000008U),
        VK_VIDEO_ENCODE_USAGE_FLAG_BITS_MAX_ENUM_KHR = (uint)(0x7FFFFFFFU),
    }
}
