using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkVideoChromaSubsamplingFlagsKHR : uint
    {
        VK_VIDEO_CHROMA_SUBSAMPLING_INVALID_KHR = (uint)(0x00000000U),
        VK_VIDEO_CHROMA_SUBSAMPLING_MONOCHROME_BIT_KHR = (uint)(0x00000001U),
        VK_VIDEO_CHROMA_SUBSAMPLING_420_BIT_KHR = (uint)(0x00000002U),
        VK_VIDEO_CHROMA_SUBSAMPLING_422_BIT_KHR = (uint)(0x00000004U),
        VK_VIDEO_CHROMA_SUBSAMPLING_444_BIT_KHR = (uint)(0x00000008U),
        VK_VIDEO_CHROMA_SUBSAMPLING_FLAG_BITS_MAX_ENUM_KHR = (uint)(0x7FFFFFFFU),
    }
}
