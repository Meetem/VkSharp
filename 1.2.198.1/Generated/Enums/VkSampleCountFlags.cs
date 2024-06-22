using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkSampleCountFlags : uint
    {
        VK_SAMPLE_COUNT_1_BIT = (uint)(0x00000001U),
        VK_SAMPLE_COUNT_2_BIT = (uint)(0x00000002U),
        VK_SAMPLE_COUNT_4_BIT = (uint)(0x00000004U),
        VK_SAMPLE_COUNT_8_BIT = (uint)(0x00000008U),
        VK_SAMPLE_COUNT_16_BIT = (uint)(0x00000010U),
        VK_SAMPLE_COUNT_32_BIT = (uint)(0x00000020U),
        VK_SAMPLE_COUNT_64_BIT = (uint)(0x00000040U),
        VK_SAMPLE_COUNT_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
