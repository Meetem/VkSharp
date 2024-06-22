using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkVideoEncodeH265CtbSizeFlagBitsKHR : uint
    {
        VK_VIDEO_ENCODE_H265_CTB_SIZE_16_BIT_KHR = (uint)(0x00000001U),
        VK_VIDEO_ENCODE_H265_CTB_SIZE_32_BIT_KHR = (uint)(0x00000002U),
        VK_VIDEO_ENCODE_H265_CTB_SIZE_64_BIT_KHR = (uint)(0x00000004U),
        VK_VIDEO_ENCODE_H265_CTB_SIZE_FLAG_BITS_MAX_ENUM_KHR = (uint)(0x7FFFFFFFU),
    }
}
