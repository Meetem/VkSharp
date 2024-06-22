using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkVideoCapabilityFlagsKHR : uint
    {
        VK_VIDEO_CAPABILITY_PROTECTED_CONTENT_BIT_KHR = (uint)(0x00000001U),
        VK_VIDEO_CAPABILITY_SEPARATE_REFERENCE_IMAGES_BIT_KHR = (uint)(0x00000002U),
        VK_VIDEO_CAPABILITY_FLAG_BITS_MAX_ENUM_KHR = (uint)(0x7FFFFFFFU),
    }
}
