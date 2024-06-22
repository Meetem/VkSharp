using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkColorComponentFlags : uint
    {
        VK_COLOR_COMPONENT_R_BIT = (uint)(0x00000001U),
        VK_COLOR_COMPONENT_G_BIT = (uint)(0x00000002U),
        VK_COLOR_COMPONENT_B_BIT = (uint)(0x00000004U),
        VK_COLOR_COMPONENT_A_BIT = (uint)(0x00000008U),
        VK_COLOR_COMPONENT_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
