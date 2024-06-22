using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkPresentScalingFlagBitsEXT : uint
    {
        VK_PRESENT_SCALING_ONE_TO_ONE_BIT_EXT = (uint)(0x00000001U),
        VK_PRESENT_SCALING_ASPECT_RATIO_STRETCH_BIT_EXT = (uint)(0x00000002U),
        VK_PRESENT_SCALING_STRETCH_BIT_EXT = (uint)(0x00000004U),
        VK_PRESENT_SCALING_FLAG_BITS_MAX_ENUM_EXT = (uint)(0x7FFFFFFFU),
    }
}
