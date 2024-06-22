using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkResolveModeFlagBits : uint
    {
        VK_RESOLVE_MODE_NONE = (uint)(0x00000000U),
        VK_RESOLVE_MODE_SAMPLE_ZERO_BIT = (uint)(0x00000001U),
        VK_RESOLVE_MODE_AVERAGE_BIT = (uint)(0x00000002U),
        VK_RESOLVE_MODE_MIN_BIT = (uint)(0x00000004U),
        VK_RESOLVE_MODE_MAX_BIT = (uint)(0x00000008U),
        VK_RESOLVE_MODE_EXTERNAL_FORMAT_DOWNSAMPLE_ANDROID = (uint)(0x00000010U),
        VK_RESOLVE_MODE_NONE_KHR = (uint)(0x00000000U),
        VK_RESOLVE_MODE_SAMPLE_ZERO_BIT_KHR = (uint)(0x00000001U),
        VK_RESOLVE_MODE_AVERAGE_BIT_KHR = (uint)(0x00000002U),
        VK_RESOLVE_MODE_MIN_BIT_KHR = (uint)(0x00000004U),
        VK_RESOLVE_MODE_MAX_BIT_KHR = (uint)(0x00000008U),
        VK_RESOLVE_MODE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
