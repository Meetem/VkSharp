using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkVideoEncodeContentFlagBitsKHR : uint
    {
        VK_VIDEO_ENCODE_CONTENT_DEFAULT_KHR = (uint)(0x00000000U),
        VK_VIDEO_ENCODE_CONTENT_CAMERA_BIT_KHR = (uint)(0x00000001U),
        VK_VIDEO_ENCODE_CONTENT_DESKTOP_BIT_KHR = (uint)(0x00000002U),
        VK_VIDEO_ENCODE_CONTENT_RENDERED_BIT_KHR = (uint)(0x00000004U),
        VK_VIDEO_ENCODE_CONTENT_FLAG_BITS_MAX_ENUM_KHR = (uint)(0x7FFFFFFFU),
    }
}
