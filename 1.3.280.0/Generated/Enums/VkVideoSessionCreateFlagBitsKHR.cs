using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkVideoSessionCreateFlagBitsKHR : uint
    {
        VK_VIDEO_SESSION_CREATE_PROTECTED_CONTENT_BIT_KHR = (uint)(0x00000001U),
        VK_VIDEO_SESSION_CREATE_ALLOW_ENCODE_PARAMETER_OPTIMIZATIONS_BIT_KHR = (uint)(0x00000002U),
        VK_VIDEO_SESSION_CREATE_INLINE_QUERIES_BIT_KHR = (uint)(0x00000004U),
        VK_VIDEO_SESSION_CREATE_FLAG_BITS_MAX_ENUM_KHR = (uint)(0x7FFFFFFFU),
    }
}
