using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkCompositeAlphaFlagsKHR : uint
    {
        VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR = (uint)(0x00000001U),
        VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR = (uint)(0x00000002U),
        VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR = (uint)(0x00000004U),
        VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR = (uint)(0x00000008U),
        VK_COMPOSITE_ALPHA_FLAG_BITS_MAX_ENUM_KHR = (uint)(0x7FFFFFFFU),
    }
}
